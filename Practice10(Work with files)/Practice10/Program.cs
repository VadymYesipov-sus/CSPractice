using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Text;

class Program {

    public static void Main(String[] args)
    {
        
        List<int> Scores = new List<int>() { 97, 92, 81, 60 };

        IEnumerable<int> queryHighScores =
            from score in Scores
            where score > 80
            select score;

        foreach (int i in queryHighScores)
        {
            Console.Write(i + " ");
        }

        string[] skills = { "C#.NET", "MVC", "WCF", "SQL", "LINQ", "ASP.NET" };
        string result = skills.Aggregate((s1, s2) => s1 + " , " + s2);
        Console.WriteLine(result);

        int[] intNumbers = { 2, 2, 3, 4 };
        int result1 = intNumbers.Aggregate(2, (n1, n2) => n1 * n2); // product of whole array
        Console.WriteLine(result1); 

        DriveInfo[] drives = DriveInfo.GetDrives();

        foreach (DriveInfo drive in drives)
        {
            Console.WriteLine("drive name:" + drive.Name);
            Console.WriteLine("type: " + drive.DriveType);
            if (drive.IsReady)
            {
                Console.WriteLine("size: " + drive.TotalSize);
                Console.WriteLine("space" + drive.TotalFreeSpace);
                Console.WriteLine("label: " + drive.VolumeLabel);
            }
        }
        

        string path1 = @"D:\testDir\data.txt";
        string path2 = @"D:\testDir\rez.txt";
        string path3 = @"D:\\";
        string path4 = @"D:\testDir\DirectoryD.txt";
        //string path5 = @"D:\testDir\\";
        string path6 = @"D:\testDir\.";
        string path7 = @"D:\testDir\datadata.txt";
        //string line = "";
        DirectoryInfo directory = new DirectoryInfo(path6);
        //FileInfo fileInf3 = new FileInfo(path4);
        FileInfo[] txtFiles = directory.GetFiles("*.txt");

        if (directory.Exists)
        {
            foreach (FileInfo file in txtFiles)
            {
                Console.WriteLine(file.Name);
                Console.WriteLine(file.Length);
            }
        }

        FileStream fs1 = File.Open(path4,
            FileMode.Create);
        string randString = "This is randomg string";
        byte[] rsByteArray = Encoding.Default.GetBytes(randString);

        fs1.Write(rsByteArray, 0 , rsByteArray.Length);
        fs1.Position = 0;

        byte[] fileByteArray = new byte[rsByteArray.Length];

        for(int i = 0; i < fileByteArray.Length; i++)
        {
            fileByteArray[i] = (byte)fs1.ReadByte();
        }

        Console.WriteLine(Encoding.Default.GetString(fileByteArray));
        fs1.Close();

        FileInfo datadataFile = new FileInfo(path7);
        BinaryWriter bw = new BinaryWriter(datadataFile.OpenWrite());
        string randText = "Random  text";
        int age = 47;
        double height = 6.1;
        bw.Write(randText);
        bw.Write(age);
        bw.Write(height);
        bw.Close();

        BinaryReader br = new BinaryReader(datadataFile.OpenRead());
        Console.WriteLine(br.ReadString());
        Console.WriteLine(br.ReadInt32());
        Console.WriteLine(br.ReadDouble());
        br.Close();

        //without it i couldn't create filestream when relaunching program 

        if (File.Exists(path4))
        {
            File.Delete(path4);
        }

        //by the time of writing this i didn't know that streams need bytes to operate on
        //so i used them to get rid of problem of opening 2 stream wirters at the same time.
        //It didn't resolve any of my problems so i decided to remove one of SWs and accept defeat.

        
            using (FileStream fs = File.Create(path4))
        {
            fs.Close(); // ??????????????????????????????????????????????????????????????????????????
        }

        
            
                using (StreamWriter sw = new StreamWriter(path4, true, System.Text.Encoding.Default))
                {
                    if (directory.Exists)
                    {
                        Console.WriteLine("Dirs");
                        string[] dirs = Directory.GetDirectories(path3);
                        foreach (string dir in dirs)
                        {
                            Console.WriteLine(dir);        
                            sw.WriteLine(dir);

                        }
                        Console.WriteLine();
                        Console.WriteLine("Files");
                        string[] files = Directory.GetFiles(path3);
                        foreach (string file in files)
                        {
                            Console.WriteLine(file);
                            sw.WriteLine(file);

                            // sw.WriteLineAsync(file);
                        }

                        sw.Close();
                    }
                   // strings.ForEach(Console.WriteLine);

                }




        FileInfo fileInf1 = new FileInfo(path1);
        FileInfo fileInf2 = new FileInfo(path2);
        StreamReader sr = fileInf1.OpenText();
        Console.WriteLine("Peek: {0}",
            Convert.ToChar(sr.Peek()));
        Console.WriteLine("1st String: {0}",
            sr.ReadLine());
        string line = sr.ReadToEnd();
        File.WriteAllText(path2, line, System.Text.Encoding.Default);

        //fileInf1.Create();
        //fileInf2.Create();
        try
        {
            using (StreamReader sr1 = new StreamReader(path1, System.Text.Encoding.Default))
            {
                line = sr1.ReadToEnd();
            }

            using (StreamWriter sw = new StreamWriter(path2, true, System.Text.Encoding.Default))
            {
                sw.WriteLine(line);
            }
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        } 

        sr.Close();
    }


    

}

