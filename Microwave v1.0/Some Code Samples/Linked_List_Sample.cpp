#include <iostream>

using namespace std;
// Class Shop
// Class Customer

// Item_List
// Shop : Item_List shop_list;
// User : Item_List user_package;

// Item_List : item_node;
// Item;

class Item
{
public:
	string name;
	int cost;
	int count;

	Item()
	{

	}


	Item(string name, int cost, int count)
	{
		this->name = name;
		this->cost = cost;
		this->count = count;
	}

	void Print_Item()
	{
		cout << "---------------------------" << endl;
		cout << "Name  : " << name << endl;
		cout << "Cost  : " << cost << endl;
		cout << "Count : " << count << endl;
		cout << "---------------------------" << endl;
	}


};

class item_node
{
public:
	Item data;
	item_node* next;

	// Methods
	item_node(Item d)
	{
		this->data = d;
		this->next = nullptr;
	}


};

class Item_List
{
	item_node* root;
	//item_node* tail;


public:
	Item_List()
	{
		root = nullptr;
		//tail = nullptr;
	}

	void Add_to_List(Item i)
	{
		if (root == nullptr)
		{
			root = new item_node(i);
			return;
		}

		item_node* iter = root;

		while (iter->next != nullptr)
		{
			iter = iter->next;
		}

		iter->next = new item_node(i);
	}

	void Print_All_List()
	{
		item_node* iter = root;

		while (iter != nullptr)
		{
			iter->data.Print_Item();
			iter = iter->next;
		}
	}

	Item& Search_Item(string name)
	{
		item_node* iter = root;
		
		if (root == nullptr)
		{
			cout << name << "couldn't find in the list." << endl;
			Item* unknown = new Item("UNKNOWN", -1, -1);
			return (*unknown);
		}


		while (iter->data.name != name)
		{
			if (iter->next == nullptr)
			{
				cout << name << "couldn't find in the list." << endl;
				Item* unknown = new Item("UNKNOWN", -1, -1);
				return (*unknown);
			}
			iter = iter->next;
		}

		return iter->data;
	}

	void Delete_Item(string item_name)
	{
		item_node* iterator = root;
		if (root->data.name == item_name)
		{
			item_node* temp = root;
			root = root->next;
			delete temp;
			return;
		}

		if (root == nullptr)
		{
			cout << item_name << " cannot be found in the list." << endl;
			return;
		}



		while (iterator->next->data.name != item_name)
		{
			iterator = iterator->next;
			if (iterator->next == NULL)
			{
				cout << item_name << " cannot be found in the list." << endl;
				return;
			}
		}
		item_node* temp = iterator->next;
		iterator->next = iterator->next->next; // temp->next; 
		delete temp;
		return;
	}



};

class Shop
{

public:
	string name;
	int money;
	Item_List shop_list;

	Shop(string name, int money)
	{
		this->name = name;
		this->money = money;
	}
};

class Customer
{
public:
	string name;
	int money;
	Item_List package;

	Customer(string name, int money)
	{
		this->name = name;
		this->money = money;
	}

	void Buy_From(Shop& shop, string name, int count)
	{
		Item& current = shop.shop_list.Search_Item(name);
		Item c_customer = current;
		int cost = current.cost * count;

		if (this->money < cost)
		{
			cout << "You don't have enough money" << endl;
			return;
		}

		if (current.name == "UNKNOWN")
		{

			cout << name << " doesn't exist." << endl;
			return;
		}

		if (current.count < count)
		{
			cout << "There is not enough" << name << endl;
			return;
		}


		current.count = current.count - count;
		c_customer.count = count;
		this->money -= cost;
		shop.money += cost;

		Item& i = package.Search_Item(name);

		if (i.name == "UNKNOWN")
			this->package.Add_to_List(c_customer);
		else
			i.count += count;
	}
};

int main()
{
	Item elma("elma", 1, 400);
	Item armut("armut", 8, 850);
	Item cilek("cilek", 5, 600);
	Item ayva("ayva", 9, 55);

	Shop manav("Kardesler", 12000);

	manav.shop_list.Add_to_List(elma);
	manav.shop_list.Add_to_List(armut);
	manav.shop_list.Add_to_List(cilek);
	manav.shop_list.Add_to_List(ayva);

	manav.shop_list.Print_All_List();
	Customer memur("Dogan", 300);

	while (1)
	{

		string alinacak;
		int adet;

		cout << "Hosgeldiniz " << memur.name << "," << endl;

		cout << "Ne almak istersiniz? ";
		cin >> alinacak;
		cout << "Adet?";
		cin >> adet;
		memur.Buy_From(manav, alinacak, adet);

		cout << "************************************************" << endl;
		cout << "************************************************" << endl;

		memur.package.Print_All_List();

		cout << "************************************************" << endl;
		cout << "************************************************" << endl;

		manav.shop_list.Print_All_List();
	}

	return 0;
}




