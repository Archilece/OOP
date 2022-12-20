class client : person
{
    int clientId = 0;
    public void clientStart()
    {
        int choice = 0;
        
        Manager mng = new Manager();
        Console.WriteLine("Welcome to Recoletos Massage Theraphy");
        Console.WriteLine("=====================================");
        Console.WriteLine("[1] Create Account");
        Console.WriteLine("[2] Payment");
        Console.WriteLine("[3] Exit");

        Console.WriteLine("=====================================");
        choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:
                createCAccount();
                clientStart();
                break;
            case 2:
                payment();
                clientStart();
                break;

            case 3:
                Environment.Exit(0);
                break;
        }
    }

    public void createCAccount()
    {
        int choice = 0;
        Console.WriteLine("Create New Client ID");
        clientId = Convert.ToInt16(Console.ReadLine());
        
        if(File.Exists("c" + clientId))
        {
            Console.WriteLine("Client ID already Exist");
            Console.WriteLine("Overwrite? [1] YES || [2] NO");
            choice = Convert.ToInt16(Console.ReadLine());
            if(choice == 1)
            {
                File.Delete("c" + clientId);
            }
            else if(choice == 2)
            {
                createCAccount();
            }
        }
         
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

    public void payment()
    {
        int clientId = 0;
        int payHr = 500;
        int paymentN;
        int initialPay = 0;
        int hour;
        int change;
        Console.WriteLine("1 Hour Is 500");
        Console.WriteLine("============================");
        Console.WriteLine("Enter Your Client ID: ");
        clientId = Convert.ToInt32(Console.ReadLine());

        if(File.Exists("h" + clientId))
        {
            Console.WriteLine("Client ID Already Paid In");
            clientStart();
        } 
        
        else if(File.Exists("c" + clientId))
        { 
            Console.WriteLine("Enter How Many Hours Of Service");
            hour = Convert.ToInt32(Console.ReadLine());
            initialPay = payHr * hour;
            Console.WriteLine("Initial Payment: " + initialPay);
            Console.WriteLine("Enter Payment: ");
            paymentN = Convert.ToInt32(Console.ReadLine());
            change = paymentN - payHr * hour;
            if(paymentN >= payHr)
            {
                if(!File.Exists("h" + clientId))
                {
                FileStream fs = new FileStream("h" + clientId ,FileMode.OpenOrCreate);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine("Client ID: " + clientId);
                sw.WriteLine("Hours Of Service: " + hour);
                sw.WriteLine("Initial Payment: " + initialPay);
                sw.WriteLine("Paid In: " + paymentN);
                sw.WriteLine("Change: " + change);
                sw.Close();
                fs.Close();
                Console.WriteLine("You Have Paid: " + paymentN);
                Console.WriteLine("Your Change: " + change);

                FileStream f1 = new FileStream("c" + clientId ,FileMode.Append);
                StreamWriter s1 = new StreamWriter(f1);
                s1.WriteLine("Payment Paid");
                s1.Close();
                fs.Close();
                }
               
            }
            else
                {
                    Console.WriteLine("Regular Payment Starts At 500");
                    Console.WriteLine("Please Try Again");
                    payment();
                }     
        }
        
        else
        {
            Console.WriteLine("Client ID Does Not Exist");
            payment();
        }
    }
}