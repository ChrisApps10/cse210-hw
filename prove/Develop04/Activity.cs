using System;

class Activity
{
    // attributes /////////////////////////////////////////////////
   protected int _duration;
   protected string _wellDone = "Well done!";

   // constructors /////////////////////////////////////////////////
   public Activity()
   {
      _duration = 20;
   }
   public Activity(int duration)
   {
      _duration = duration;
   }

   
    // methods /////////////////////////////////////////////////
    public void runActivity(int choice)
    {
        if (choice == 1)
        {
            Breathing breathingActivity = new Breathing(_duration);
            breathingActivity.runBreathingActivity(_duration);

        } 
        else if (choice == 2)
        {
            Reflecting reflectingActivity = new Reflecting (_duration);
            reflectingActivity.runReflectingActivity(_duration);
        }
        else if (choice == 3)
        {
            Listing listingActivity = new Listing(_duration);
            listingActivity.runListingActivity(_duration);
        }
    }
   public void setDuration()
   {
    Console.WriteLine("How long, in seconds, would you like for your session? ");
    string response = Console.ReadLine();
    int duration = int.Parse(response);
    _duration = duration * 100;
   }

   public int getDuration()
   {
    return _duration;
   }
}

  