#include<iostream>
#include<string.h>
#include <bits/stdc++.h> 
using namespace std; 
int no;
int travellingSalesmanProblem( int s);
int main() 
{ 	
	int s = 0; 
	cout << travellingSalesmanProblem(s) << endl; 
	return 0; 
} 

int travellingSalesmanProblem( int s) 
{ 
	cout<<"Enter no of cities : ";
	cin>>no;
	string cities[(const int)no];
	
	int graph[(const int)no][(const int)no]={0};
	
	
	for(int i=0;i<no;i++)
	{
		cout<<"\nCity "<<i+1<<" : ";
		cin>>cities[i];
	}
	
	cout<<"\n\t\t\t E N T E R	 C O S T S\n\n";
	for(int i=0;i<no;i++)
	{
		for(int j=0;j<no;j++)
		{
			if(i==j)
			{
				continue;
			}
			cout<<endl<<"Cost from "<<cities[i]<<" to "<<cities[j]<<" : ";
			cin>>graph[i][j];
		}
	}
	
	
	cout<<"\n\n";
	cout<<"\n\t\t\t M A T R I X		F O R M E D \n\n";
	for(int i=0;i<no;i++)
	{
		cout<<"\n\n";
		for(int j=0;j<no;j++)
		{
			cout<<"  "<<graph[i][j]<<"  ";
		}
	}
	
	
		cout<<"\n";
		cout<<"\nEnter Starting City : ";
		cin>>s;
		if(s>=0 || s<no)
		{
			cout<<endl;
			
		}
		else
		{
			cout<<"INVALID INPUT";
			return 0;
		}
		s=s-1;
	vector<int> vertex; 
	for (int i = 0; i < no; i++) 
		if (i != s) 
			vertex.push_back(i);
			
	int low_path[(const int)(no+1)]={0}; 
	int min_path = INT_MAX; 
	
	do { 
		int current_pathweight = 0; 
	 	int path[(const int)(no+1)]={0};
		int k = s; 
		path[0]=s+1;
		for (int i = 0; i < vertex.size(); i++) { 
			//cout<<vertex[i]<<endl;
			
			//cout<<cities[k]<<endl;
			//cout<<cities[vertex[i]]<<endl;
			//cout<<cities[vertex[k]]<<endl;
			//cout<<"-"<<endl;
			path[i+1]=vertex[i]+1;
			current_pathweight += graph[k][vertex[i]]; 
			k = vertex[i]; 
		} 
		current_pathweight += graph[k][s]; 
		int chk=min_path;
		// update minimum 
		 if (min_path>current_pathweight)
		 {
		 	min_path =current_pathweight;
		 }
        if(min_path!=chk)
		{
			for(int j=0;j<no;j++)
				{
					low_path[j]=path[j];
				}
		}
	} while (next_permutation(vertex.begin(), vertex.end())); 
	
	cout<<"\nPath : ";
	low_path[no]=s+1;
	int temp=0;
	for(int i=0;i<=no;i++)
	{
		if(i!=0)
		{
			cout<<"---->";
		}
		//cout<<low_path[i];
		//cout<<"-----------"<<endl;
		temp=low_path[i]-1;
		//cout<<"temp: "<<temp;
		cout<<cities[temp];
		//cout<<"-----------"<<endl;
	}

	cout<<endl;
	cout<<"COST: ";
	return min_path; 
} 



