#include<iostream>//input and output screen
#include<string.h>//present different character
#include<fstream>//read and write a file
#include<stdlib.h>//exist data
using namespace std;//compiler
char found='f';
class product//class declaration
{
	private:
		char prname[25];
		char prid[25];
		char prcate[25];
		int prqty;
	public://used from main
			void getdata()// void is used for no return vlues
			{
				cout<<"Enter name of the product: ";//output
				cin>>prname;//input
				cout<<"Enter product ID: ";
				cin>>prid;
				cout<<"Enter product category(Electronics,Household,Furniture): ";
				cin>>prcate;
				cout<<"Enter Quantity On Hand:";
				cin>>prqty;
			}
			void showdata()
			{
				cout<<prname<<" "<<prid<<" "<<prcate<<" "<<prqty<<endl;
			}
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
int main()//all the programs start here
{
    product p1,p2,p3;//Object Declaration
	int choice, i ,count=0;
	char result;//result for process
	cout<<"Main Menu\n"<<endl;
	cout<<"1. Add a new product to the file:"<<endl;
	cout<<"2. Modifies the details of an existing product:"<<endl;
	cout<<"3. Displays the product details from the file:"<<endl;
	cout<<"4. Exit:"<<endl;
	cout<<"Choose the one(1-4): ";
	cin>>choice;
	do{
		if(choice==1)
		{
			ofstream fio("Product.dat",ios::out);//to create and write the inforamation file
			if(fio.is_open())//open file
			{
				do{
				    p1.getdata();//take data from getdata function
				    fio.write((char*)&p1,sizeof(p1));
				    count++;
				    cout<<"Record is added to the file.:\n";
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
			streampos pos;//absolute position within stream
			cout<<"Enter product ID that you want to modify: ";
			cin>>id;
			fstream in_out("Product.dat",ios::in|ios::out|ios::binary);//open operations for input,output and binary
			in_out.seekg(0);//operate pointer from the top
			if(in_out.is_open())
				while(!in_out.eof())//process until the end of line
				{
					pos=in_out.tellg();//get positon
					in_out.read((char*)&p3,sizeof(p3));
					if(p3.compareid(id)==1)
					{
					p3.showdata();//get data from showdata function
					p3.modifydata();//get data from modifydata function
					in_out.seekp(pos);//put data
					in_out.write((char*)&p3,sizeof(p3));
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
		   ifstream infile;//to read the file
		   i=1;//to store record 1
		   infile.open("Product.dat",ios::in);//read value and return file
		   while(!infile.eof()&&i<=count)
		   {
		   	infile.read((char*)&p2,sizeof(p2));//read file
		   	p2.showdata();
		   	i++;
		   }
		   infile.close();//close file	
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
