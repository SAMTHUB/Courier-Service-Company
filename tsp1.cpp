#include<iostream>
#include<string.h>
#include <bits/stdc++.h> 
using namespace std; 
int no;

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
	
	
	for(int i=0;i<no;i++)
	{
		for(int j=0;j<no;j++)
		{
			if(i==j)
			{
				continue;
			}
			cout<<"Cost from "<<cities[i]<<" to "<<cities[j]<<" : ";
			cin>>graph[i][j];
		}
	}
	
	
	cout<<"\n\n";
	for(int i=0;i<no;i++)
	{
		cout<<"\n\n";
		for(int j=0;j<no;j++)
		{
			cout<<"  "<<graph[i][j]<<"  ";
		}
	}
	
	
	cout<<"\n";
	vector<int> vertex; 
	for (int i = 0; i < no; i++) 
		if (i != s) 
			vertex.push_back(i); 
	int min_path = INT_MAX; 
	
	do { 
		int current_pathweight = 0; 
	 
		int k = s; 
		for (int i = 0; i < vertex.size(); i++) { 
			current_pathweight += graph[k][vertex[i]]; 
			k = vertex[i]; 
		} 
		current_pathweight += graph[k][s]; 

		// update minimum 
		min_path = min(min_path, current_pathweight);
		 
		
	} while (next_permutation(vertex.begin(), vertex.end())); 

	return min_path; 
} 

int main() 
{ 	
	int s = 0; 
	cout << travellingSalesmanProblem(s) << endl; 
	return 0; 
} 

