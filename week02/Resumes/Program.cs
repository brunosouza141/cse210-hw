using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Amazon";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2024;
        job1._endYear = 2025;

        Job job2 = new Job();
        job2._company = "Crowdstrike";
        job2._jobTitle = "IAM Engineer";
        job2._startYear = 2022;
        job2._endYear = 2023;


        Resume resume = new Resume();
        resume._name = "Bruno Souza";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.Display();
    }
}