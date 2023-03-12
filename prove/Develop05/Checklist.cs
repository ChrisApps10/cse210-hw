using System;

class ChecklistGoal : goalType
{

    public ChecklistGoal()
    {   
    }

    public override int calculatePoints()
    {
        if (_completions == _requiredCompletions)
        {
            return _goalPoints + _bonusPoints;
        }
        return _goalPoints;
    }
}