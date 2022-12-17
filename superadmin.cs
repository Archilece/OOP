class superAdmin : person
{
    public int staffId;
    public int clientId;

    public void superAdminStart()
    {
        int choice = 0;
        Console.WriteLine("-------------------------");
        Console.WriteLine("Create Client Account [1]");
        Console.WriteLine("Create Staff Account [2]");
        Console.WriteLine("Remove Client Account [3]");
        Console.WriteLine("Remove Staff Account [4]");
        Console.WriteLine("EXIT [5]");
        Console.WriteLine("-------------------------");

        choice = Convert.ToInt16(Console.ReadLine());

        switch (choice)
        {
            case 1: 
                createCAccount();
            break;
            case 2: 
                createSAccount();
            break;
            case 3: 
                Console.WriteLine("This Is To Remove A Client Account");
                removeClient();
            break;
            case 4: 
                 Console.WriteLine("This Is To Remove A Staff Account");
                 staffId = Convert.ToInt16(Console.ReadLine());
                 removeStaff();
            break;
            case 5: 
                Environment.Exit(0);
            break;
        }

    }

    public void createCAccount()
    {
        Console.WriteLine("Create New Client ID");
        clientId = Convert.ToInt16(Console.ReadLine());
        
        if(File.Exists("c" + clientId))
        {
            Console.WriteLine("Client ID already Taken");
            createCAccount();
        }
        else
        {   
            FileStream fs = new FileStream("c" + clientId ,FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);

            Console.WriteLine(" First Name: ");
            fName = Console.ReadLine();
            Console.WriteLine(" Middle Name: ");
            mName = Console.ReadLine();
            Console.WriteLine(" Last Name: ");
            lName = Console.ReadLine();
            Console.WriteLine(" Age: ");
            Age = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(" Gender: ");
            Gender = Console.ReadLine();
            Console.WriteLine(" Present Residence:  ");
            pResidence = Console.ReadLine();
            Console.WriteLine(" Home Residence: ");
            hResidence = Console.ReadLine();

            
            sw.WriteLine("Full Name: {0} {1} {2} " ,fName,mName, lName);
            sw.WriteLine("Age: " + Age);
            sw.WriteLine("Present Residence: " + pResidence);
            sw.WriteLine("Home Residence: " + hResidence);

            sw.Close();
            fs.Close();
            Console.WriteLine("Client Account Created");
            Console.WriteLine("-------------------------");
            superAdminStart();
        }

        
    }

    public void createSAccount()
    {
        Console.WriteLine("Create New Staff ID");
        
        staffId = Convert.ToInt16(Console.ReadLine());
        
        if(File.Exists("s" + staffId))
        {
            Console.WriteLine("Staff ID already Taken");
            createSAccount();
        }
        else
        {   
            FileStream fs = new FileStream("s" + staffId ,FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);

            Console.WriteLine(" First Name: ");
            fName = Console.ReadLine();
            Console.WriteLine(" Middle Name: ");
            mName = Console.ReadLine();
            Console.WriteLine(" Last Name: ");
            lName = Console.ReadLine();
            Console.WriteLine(" Age: ");
            Age = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(" Gender: ");
            Gender = Console.ReadLine();
            Console.WriteLine(" Present Residence:  ");
            pResidence = Console.ReadLine();
            Console.WriteLine(" Home Residence: ");
            hResidence = Console.ReadLine();

            
            sw.WriteLine("Full Name: {0} {1} {2} " ,fName,mName, lName);
            sw.WriteLine("Age: " + Age);
            sw.WriteLine("Present Residence: " + pResidence);
            sw.WriteLine("Home Residence: " + hResidence);

            sw.Close();
            fs.Close();
            Console.WriteLine("Staff Account Created");
            Console.WriteLine("-------------------------");
            superAdminStart();
        }
    }


    public void removeClient()
    {
        
        Console.WriteLine("Enter Client ID To Remove");
        clientId = Convert.ToInt16(Console.ReadLine());
        if(!File.Exists("c" + clientId))
        {
            Console.WriteLine("Invalid Client ID"); 
            Console.WriteLine(" Enter Valid ID ");
            removeClient();
        }   
        
        else
        {
        String myPath = "c" + clientId;
        Console.WriteLine("Client ID Remove");
        File.Delete(myPath);
        }
    }

    public void removeStaff()
    {
        Console.WriteLine("Enter Staff ID To Remove");
        staffId = Convert.ToInt16(Console.ReadLine());
        if(!File.Exists("s" + staffId))
        {
            Console.WriteLine("Invalid Staff ID"); 
            Console.WriteLine(" Enter Valid ID ");
            removeStaff();
        }  
        else
        {
        String myPath = "s" + staffId;
        Console.WriteLine("Staff ID Remove");
        File.Delete(myPath);
        }
    }



}