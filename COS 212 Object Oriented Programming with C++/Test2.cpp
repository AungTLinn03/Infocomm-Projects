#include<iostream>//input and output screen
#include<string.h>//present different character
#include<fstream>//read and write a file
#include<stdlib.h>//exist data
using namespace std;//compiler
char found='f';
class product//class declaration
{
	protected:
		char prname[25];
		char prid[25];
		char prcate[25];
		int prqty;
	public://used from main
			
			void modifydata()
			{
				char name[25];
				char categ[25];
				int qty;
				cout<<"Enter the new data."<<endl;
				cout<<"Enter the name: ";
				cin>>name;
				cout<<"Enter the category: ";
				cin>>categ;
				cout<<"Enter the quantity: ";
				cin>>qty;
				//strcpy(prid,id);
				strcpy(prname,name);//copy charcters to source destination
				strcpy(prcate,categ);
				prqty=qty;
			}
			int compareid(char id[25])//comapare values
			{
				if(strcmp(prid,id)==0)//calling whith parameters
				{
				
					return 1;
				}
				else
				{
				return 0;
			    }
			}
			
};
class Task:public product//declaration of derived class
{
	public:
		void getdata()
			{
				cout<<"Enter name of the product: ";
				cin>>prname;
				cout<<"Enter product ID: ";
				cin>>prid;
				cout<<"Enter product category(Electronics,Household,Furniture): ";
				cin>>prcate;
				cout<<"Enter Quantity On Hand:";
				cin>>prqty;
			}
			void putdata()
			{
				cout<<prname<<" "<<prid<<" "<<prcate<<" "<<prqty<<endl;
			}
		void modifydata()
		{
			product::modifydata();
		}
};
int main()//all the programs start here
{
    Task m1,m2,m3;//object declaration
	int choice, i ,count=0;
	char result;//result for process
	cout<<"Main Menu\n"<<endl;
	cout<<"1. Add a new product to the file.:"<<endl;
	cout<<"2. Modifies the details of an existing product.:"<<endl;
	cout<<"3. Displays the product details from the file.:"<<endl;
	cout<<"4. Exit:"<<endl;
	cout<<"Choose the one(1-4): ";
	cin>>choice;
	do{
		if(choice==1)
		{
			ofstream fio("Product.dat",ios::out);//to write in file
			if(fio.is_open())//open the file
			{
				do{
				    m1.getdata();//take data from getdata function
				    fio.write((char*)&m1,sizeof(m1));//to write address of t1
				    count++;
				    cout<<"Record is added to the file.\n";
				    cout<<"Would you like to add more(y/n)? : ";
				    cin>>result;
			    }while(result=='y'||result=='Y');
			}
			else
			{
				cout<<"You can't open file.:";
			}
			fio.close();//close file
		}
		else if(choice==2)
		{
			char id[25];
			streampos pos;//store position
			cout<<"Enter product ID that you want to modify: ";
			cin>>id;
			fstream in_out("Product.dat",ios::in|ios::out|ios::binary);//inputa and output
			in_out.seekg(0);//show pointer from top file
			if(in_out.is_open())
				while(!in_out.eof())
				{
					pos=in_out.tellg();//get data
					in_out.read((char*)&m3,sizeof(m3));//read address of t3
					if(m3.compareid(id)==1)
					{
					m3.putdata();//get data from putdata function
					m3.modifydata();//get data from modifydata function
					in_out.seekp(pos);//to put data
					in_out.write((char*)&m3,sizeof(m3));
					found=true;
					cout<<"Successfully modified.:";
					break;
				 	}
				}
			if(found=='f')
			{
				cout<<"Product ID is not found in the file.:\n";
				cout<<"Presss any key to exist : ";
				exit(1);
			}
			in_out.close();
		}
		else if(choice==3)
		{
		   ifstream infile;//to read file
		   i=1;
		   infile.open("Product.dat",ios::in);
		   while(!infile.eof()&&i<=count)
		   {
		   	infile.read((char*)&m2,sizeof(m3));//read address of t2
		   	m2.putdata();
		   	i++;
		   }
		   infile.close();//to close file	
		}
		else
		{
			cout<<"This is the end of program.:";
			exit(2);
		}
		cout<<"Do you want to do more process?";
		cout<<"Choose(1-4):";
		cin>>choice;
	}while(choice>=1 && choice<=4);
	return 0;//execution program end here
}
