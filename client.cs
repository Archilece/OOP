class client : person
{
    int clientId = 0;
    public void clientStart()
    {
        int choice = 0;
        programStart pS = new programStart();
        Manager mng = new Manager();
        
        Console.WriteLine("Welcome to Recoletos Massage Theraphy");
        Console.WriteLine("=====================================");
        Console.WriteLine("[1] Request Service");
        Console.WriteLine("[2] Create Account");
        Console.WriteLine("[3] Payment");
        Console.WriteLine("[4] EXIT");
        Console.WriteLine("=====================================");
        choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:
                requestService();
                break;
            case 2:
                createCAccount();
                requestService();
                break;

            case 3:
                mng.payment();
                break;
            case 4:
                Environment.Exit(0);
                break;
        }
    }
    public void requestService()
    {
        string? clientRequest;
        Console.WriteLine("Request");
        Console.WriteLine("===============");
        Console.WriteLine("Enter Client ID");
        clientId = Convert.ToInt16(Console.ReadLine());
        
        if(File.Exists("c" + clientId))
        {   
            Console.WriteLine("Enter Your Request And Hour Of Service: ");
            clientRequest = Console.ReadLine();

            FileStream f1 = new FileStream("c" + clientId, FileMode.Append);
            StreamWriter s1 = new StreamWriter(f1);
            s1.WriteLine("Client Request: " + clientRequest);
            s1.Close();
            f1.Close();
        }
        else
        {
            Console.WriteLine("Invalid Client ID");
            clientStart();
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
           
        }
    }
}