using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Wireless Hardware Engineer";
        job1._company = "Apple";
        job1._startYear = 2025;
        job1._endYear = 2029;

        Job job2 = new Job();
        job2._jobTitle = "Software Engineer";
        job2._company = "Google";
        job2._startYear = 2030;
        job2._endYear = 2045;

        Resume myResume = new Resume();
        myResume._name = "Chris Aparicio";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}