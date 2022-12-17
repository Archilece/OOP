class Staff : person
{
    int staffID;
    string? staffSkills;

    public void managerStart()
    {
        int choice = 0;

        Console.WriteLine("        Staff Controls       ");
        Console.WriteLine("Press [1] For Staff 1 Control");
        Console.WriteLine("Press [2] For Staff 2 Control");
        Console.WriteLine("Press [3] For Staff 3 Control");




        choice = Convert.ToInt32(Console.ReadLine());
        if (choice == 1)
        {
            staffID = 1;
            staff1Cont(staffID);
        }
        else if (choice == 2)
        {
            staffID = 2;
            staff2Cont(staffID);
        }
        else if (choice == 3)
        {
            staffID = 3;
            staff3Cont(staffID);
        }

        else
        {
            Console.WriteLine("Error! Press Only 1 Or 2");
            managerStart();
        }
    }



    //STAFF1
    public void staff1Cont(int staffID)
    {
        int choice = 0;

        if (!File.Exists("M" + staffID))
        {
            Console.WriteLine("Manager 1 Account Does not Exist");
            Console.WriteLine("Create New Account");

            FileStream fs = new FileStream("M" + staffID, FileMode.OpenOrCreate);
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


            sw.WriteLine("Full Name: {0} {1} {2} ", fName, mName, lName);
            sw.WriteLine("Age: " + Age);
            sw.WriteLine("Present Residence: " + pResidence);
            sw.WriteLine("Home Residence: " + hResidence);

            sw.Close();
            fs.Close();
            Console.WriteLine("Manager 1 Account Created");
            Console.WriteLine("-------------------------");
            staff1Cont(staffID);
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
                    staff1Cont(1);
                    break;
                case 2:
                    removeStaff();
                    staff1Cont(1);
                    break;
                case 3:
                    //SEE Client TEXT FILES and Update With Client Request: 
                    see();

                    break;
            }

        }

    }

    //STAFF2
    public void staff2Cont(int staffID)
    {
        int choice = 0;
        superAdmin m2 = new superAdmin();
        if (!File.Exists("M" + staffID))
        {
            Console.WriteLine("Manager 2 Account Does not Exist");
            Console.WriteLine("Create New Account");

            FileStream fs = new FileStream("M" + staffID, FileMode.OpenOrCreate);
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


            sw.WriteLine("Full Name: {0} {1} {2} ", fName, mName, lName);
            sw.WriteLine("Age: " + Age);
            sw.WriteLine("Present Residence: " + pResidence);
            sw.WriteLine("Home Residence: " + hResidence);

            sw.Close();
            fs.Close();
            Console.WriteLine("Manager 2 Account Created");
            Console.WriteLine("-------------------------");
            staff2Cont(staffID);
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
                    staff2Cont(2);
                    break;
                case 2:

                    removeStaff();
                    staff2Cont(2);
                    break;
                case 3:
                    //SEE Client TEXT FILES and Update With Client Request: 
                    see();

                    break;
            }
        }
    }

    //STAFF2
    public void staff3Cont(int staffID)
    {
        int choice = 0;
        superAdmin m2 = new superAdmin();
        if (!File.Exists("M" + staffID))
        {
            Console.WriteLine("Manager 2 Account Does not Exist");
            Console.WriteLine("Create New Account");

            FileStream fs = new FileStream("M" + staffID, FileMode.OpenOrCreate);
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


            sw.WriteLine("Full Name: {0} {1} {2} ", fName, mName, lName);
            sw.WriteLine("Age: " + Age);
            sw.WriteLine("Present Residence: " + pResidence);
            sw.WriteLine("Home Residence: " + hResidence);

            sw.Close();
            fs.Close();
            Console.WriteLine("Manager 2 Account Created");
            Console.WriteLine("-------------------------");
            staff3Cont(staffID);
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
                    staff2Cont(2);
                    break;
                case 2:

                    removeStaff();
                    staff2Cont(2);
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
        // string? staffId;
        Console.WriteLine("Create New Staff ID");
        int staffId = 0;
        staffId = Convert.ToInt32(Console.ReadLine());


        if (File.Exists("s" + staffId))
        {
            Console.WriteLine("Staff ID already Taken");

        }
        else
        {
            FileStream fs = new FileStream("s" + staffId, FileMode.Create);
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


            sw.WriteLine("Full Name: {0} {1} {2} ", fName, mName, lName);
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
        if (!File.Exists("s" + staffId))
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
        Console.WriteLine("Enter Client ID to View");
        clientId = Convert.ToInt32(Console.ReadLine());
        using (TextReader tr = File.OpenText("c" + clientId))
        {
            Console.WriteLine(tr.ReadToEnd());
        }
    }
}