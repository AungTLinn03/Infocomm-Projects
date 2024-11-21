#include<iostream>//input and output screen
#include<string.h>//present different character
#include<fstream>//read and write a file
#include<stdlib.h>//exist data
using namespace std;//compiler
char found='f';
class product//declaration of base classes
{
	protected:
		char prname[25];
		char prid[25];
		char prcate[25];
		int prqty;
	public://to use from main function
		virtual void getdata()=0;
		virtual void showdata()=0;
		virtual void modifydata()=0;
		virtual int compareid(char id [25])=0;	
};
class object:public product//declartion derived class
{
	public:
			virtual void getdata()
			{
				cout<<"Enter name of the product: ";
				cin>>prname;
				cout<<"Enter product ID: ";
				cin>>prid;
				cout<<"Enter product category(Electronics,Household,Furniture): ";
				cin>>prcate;
				cout<<"Enter Quantity On Hand";
				cin>>prqty;
			}
			virtual void showdata()
			{
				cout<<prname<<" "<<prid<<" "<<prcate<<" "<<prqty<<endl;
			}
			virtual void modifydata()
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
				strcpy(prname,name);
				strcpy(prcate,categ);
				prqty=qty;
			}
			virtual int compareid(char id[25])
			{
				if(strcmp(prid,id)==0)//use string to compare function
				{
					return 1;
				}
				else
				{
				return 0;
			    }
			}
			
};
int main()
{
    //product m1,m2,m3;
    product * a=NULL;//pointer to obtain address
	int choice, i ,count=0;
	char result;//result the process
	cout<<"Main Menu\n"<<endl;
	cout<<"1. Add a new product to the file."<<endl;
	cout<<"2. Modifies the details of an existing product."<<endl;
	cout<<"3. Displays the product details from the file."<<endl;
	cout<<"4. Exit"<<endl;
	cout<<"Choose the one(1-4): ";
	cin>>choice;
	do{
		if(choice==1)
		{
			object B1;//declaration of object
			a=&B1;//run-time declaration
			ofstream fio("Product.dat",ios::out);//to write in file
			if(fio.is_open())
			{
				do{
				    a->getdata();//indirect address
				    fio.write((char*)&B1,sizeof(B1));//to write address of B1
				    count++;//increment
				    cout<<"Record is added to the file.\n";
				    cout<<"Would you like to add more(y/n)? : ";
				    cin>>result;
			    }while(result=='y'||result=='Y');
			}
			else
			{
				cout<<"You can't open file.";
			}
			fio.close();//close file
		}
		else if(choice==2)
		{
			object B3;//declaration of object
			a=&B3;//runtime declaration
			char id[25];
			streampos pos;//to store position
			cout<<"Enter product ID that you want to modify: ";
			cin>>id;
			fstream in_out("Product.dat",ios::in|ios::out|ios::binary);//open operations for input,output and binary
			in_out.seekg(0);//to show the pointer
			if(in_out.is_open())
				while(!in_out.eof())
				{
					pos=in_out.tellg();//getposition
					in_out.read((char*)&B3,sizeof(B3));//to read address of B3
					if(a->compareid(id)==1)
					{
					a->showdata();//get data from showdata function
					a->modifydata();//get data form modifydata function
					in_out.seekp(pos);
					in_out.write((char*)&B3,sizeof(B3));
					found=true;
					cout<<"Successfully modified.";
					break;
				 	}
				}
			if(found=='f')
			{
				cout<<"Product ID is not found in the file.\n";
				cout<<"Presss any key to exist : ";
				exit(1);
			}
			in_out.close();
		}
		else if(choice==3)
		{
		   object B2;//declaration object
		   a=&B2;//run-time declaration
		   ifstream infile;//to read file
		   i=1;
		   infile.open("Product.dat",ios::in);
		   while(!infile.eof()&&i<=count)
		   {
		   	infile.read((char*)&B2,sizeof(B2));//to read address of B2
		   	a->showdata();
		   	i++;//increment record
		   }
		   infile.close();	
		}
		else
		{
			cout<<"This is the end of program.";
			exit(2);
		}
		cout<<"Do you want to do more process?";
		cout<<"Choose(1-4):";
		cin>>choice;
	}while(choice>=1 && choice<=4);
	return 0;//execution program end here
}
