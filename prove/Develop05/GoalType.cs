using System;

class goalType
{
    protected string _nameQuestion = "What is the name of your goal?";
    protected string _desQuestion = "What is a short description of it?";
    protected string _pointsQuestion = "What is the amount of points associated with this goal?";

    protected string _goalTitle;
    protected string _goalDescription;
    protected int _goalPoints;
    protected bool _completed = false;

    protected int _bonusPoints;
    protected int _completions = 0;
    protected int _requiredCompletions = 0;

    protected string _completionsNeededQuestion = "How many times does this need completed to qualify for a bonus?";
    protected string _bonusQuestion = "What is the bonus for accomplishing it that many times?";

    public goalType()
    {

    }

    public virtual int calculatePoints()
    {
        return _goalPoints;
    }

    public string getNameQuestion()
    {
        return _nameQuestion;
    }

     public string getDesQuestion()
    {
        return _desQuestion;
    }

     public string getPointsQuestion()
    {
        return _pointsQuestion;
    }

    public string getGoalTitle()
    {
        return _goalTitle;
    }

    public string getGoalDescription()
    {
        return _goalDescription;
    }

    public int getGoalPoints()
    {
        return _goalPoints;
    }

    public void setGoalTitle(string goalTitle)
    {
        _goalTitle = goalTitle;
    }

    public void setGoalDescription(string goalDescription)
    {
        _goalDescription = goalDescription;
    }

    public void setGoalPoints(int goalPoints)
    {
        _goalPoints = goalPoints;
    }

    public void addGoal(string fullGoalString, string fileString, string fileName)
    {
        File.AppendAllText(fileName, fullGoalString + Environment.NewLine);
    }

    public bool getCompleted()
    {
        return _completed;
    }

    public virtual void setCompleted(bool completed)
    {
        _completed = completed;
    }

    public string getCompletionsQuestion()
    {
        return _completionsNeededQuestion;
    }

    public string getBonusQuestion()
    {
        return _bonusQuestion;
    }

    public int getBonusPoints()
    {
        return _bonusPoints;
    }

    public void setBonusPoints(int bonusPoints)
    {
        _bonusPoints = bonusPoints;
    }

    public int getCompletions()
    {
        return _completions;
    }

    public void setCompletions(int completions)
    {
        _completions = completions;
    }

    public int getNeededCompletions()
    {
        return _requiredCompletions;
    }

    public void setNeededCompletions(int neededCompletions)
    {
        _requiredCompletions = neededCompletions;
    }
}