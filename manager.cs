class Manager : person
{
    int managerID;
    
    public void managerStart()
    {
        int choice = 0;
        
        Console.WriteLine("        Manager Controls       ");
        Console.WriteLine("Press [1] For Manager 1 Control");
        Console.WriteLine("Press [2] For Manager 2 Control");
        
        choice = Convert.ToInt32(Console.ReadLine());
        if(choice == 1)
        {
            managerID = 1;
            manager1Cont(managerID);
        }
        else if(choice == 2)
        {
            managerID = 2;
            manager2Cont(managerID);
        }
        else
        {
            Console.WriteLine("Error! Press Only 1 Or 2");
            managerStart();
        }
    }



    //MANAGER1
    public void manager1Cont(int managerID)
    {
        int choice = 0;
        programStart ps = new programStart(); 
         if(!File.Exists("M" +  managerID))
        {
            Console.WriteLine("Manager 1 Account Does not Exist");
            Console.WriteLine("Create New Account");

            FileStream fs = new FileStream("M" +  managerID ,FileMode.OpenOrCreate);
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
            Console.WriteLine("Manager 1 Account Created");
            Console.WriteLine("-------------------------"); 
            manager1Cont(managerID);
        }
        else
        {   
        Console.WriteLine("Manager Controls");    
        Console.WriteLine("[1]Hire Staff");
        Console.WriteLine("[2]Fire Staff");
        Console.WriteLine("[3]See Client Request");
        choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:
                createSAccount(); 
                manager1Cont(1);
                break;
            case 2:
                removeStaff();
                manager1Cont(1);
                break;
            case 3:
                //SEE Client TEXT FILES and Update With Client Request: 
                see();
                break;
        }
        
        }

    }

    //MANAGER2
    public void manager2Cont(int managerID)
    {
        int choice = 0;
        superAdmin m2 = new superAdmin();
         if(!File.Exists("M" +  managerID))
        {
            Console.WriteLine("Manager 2 Account Does not Exist");
            Console.WriteLine("Create New Account");

            FileStream fs = new FileStream("M" +  managerID ,FileMode.OpenOrCreate);
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
            Console.WriteLine("Manager 2 Account Created");
            Console.WriteLine("-------------------------"); 
            manager2Cont(managerID);
        }
        else
        {   
        Console.WriteLine("Manager Controls");    
        Console.WriteLine("[1]Hire Staff");
        Console.WriteLine("[2]Fire Staff");
        Console.WriteLine("[3]See Client Request");
        choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:
            
                createSAccount(); 
                manager2Cont(2);
                break;
            case 2:
                
                removeStaff();
                manager2Cont(2);
                break;
            case 3:
                //SEE Client TEXT FILES and Update With Client Request: 
                see();
                break;
        }   
        }
    }

    public void createSAccount()
    {
        Console.WriteLine("Create New Staff ID");
        int staffId = 0;
        staffId = Convert.ToInt32(Console.ReadLine());
        
        
        if(File.Exists("s" + staffId))
        {
            Console.WriteLine("Staff ID already Taken");
            
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
        }

       
    }
    public void removeStaff()
       {
        int staffId = 0;
        Console.WriteLine("Enter Staff ID To Remove");
        staffId = Convert.ToInt32(Console.ReadLine());
        if(!File.Exists("s" + staffId))
        {
            Console.WriteLine("Invalid Staff ID"); 
            removeStaff();
        }  
        else
        {
        String myPath = "s" + staffId;
        Console.WriteLine("Staff ID Remove");
        File.Delete(myPath);
        }
        }


    public void see()
    {
      int clientId = 0;
      int clientFee = 0;
      Console.WriteLine("Enter Client ID to View");
      clientId = Convert.ToInt32(Console.ReadLine());
      if(File.Exists("c" + clientId))
      {
        
        using (TextReader tr = File.OpenText("c" + clientId))
        {
        Console.WriteLine(tr.ReadToEnd());
        }
       
        Console.WriteLine("Enter Service Fee: 1 Hour (500) 1 Hour Above (1000)");
        clientFee = Convert.ToInt32(Console.ReadLine());
        

        FileStream f1 = new FileStream("c" + clientId, FileMode.Append);
        StreamWriter s1 = new StreamWriter(f1);
        s1.WriteLine("Client Fee: " + clientFee);
        s1.Close();
        f1.Close();

        if(File.Exists("h" + clientId))
        {
            FileStream f2 = new FileStream("h" + clientId, FileMode.Append);
            StreamWriter s2 = new StreamWriter(f2);
            s2.WriteLine("Client Fee: " + clientFee);
            s2.Close();
            f2.Close();
        }
      }
      else
      {
        Console.WriteLine("Client ID Does Not Exist");
        see();
      }
    }

    public void payment()
    {
        int clientId = 0;
        int paymentN;
        Console.WriteLine("500 1 Hour 1000 1 Hour Above");
        Console.WriteLine("============================");
        Console.WriteLine("Enter Your Client ID: ");
        clientId = Convert.ToInt32(Console.ReadLine());
        

        if(File.Exists("c" + clientId))
        { 
            Console.WriteLine("Enter Cash To Pay: ");
            paymentN = Convert.ToInt32(Console.ReadLine());
            FileStream fs = new FileStream("h" + clientId ,FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("Client ID: " + clientId);
            sw.WriteLine("Paid In: " + paymentN);
            sw.Close();
            fs.Close();
            Console.WriteLine("You Have Paid: " + paymentN);
        }
        else
        {
            Console.WriteLine("Client ID Already Paid In");
            payment();
        }
    }

    
} 