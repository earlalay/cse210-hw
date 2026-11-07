class BreathingAct : Activities
{
    List<int> _breathingLengths = [];
    // constructors
    public BreathingAct(string name, string description, int duration) : base(name, description, duration)
    {
        
    }

    // behaviors

    public void Run()
    {
        int seconds = GetDuration();
        if (seconds <= 60)
        {
            DetermineBreathingLength(seconds);
        }
        else
        {   int extraSeconds = seconds - 60;
            _breathingLengths = [2, 3, 3, 3, 3, 4, 4, 4, 4, 5, 6, 6, 6, 7];
            if (extraSeconds <= 5)
            {
                _breathingLengths.Add(extraSeconds);
            }
            else if (extraSeconds < 10)
            {
                double dividedSeconds = extraSeconds / 2.0;
                int breatheIn = (int)Math.Floor(dividedSeconds);
                int breatheOut = (int)Math.Ceiling(dividedSeconds);
                _breathingLengths.Add(breatheIn);
                _breathingLengths.Add(breatheOut);
            }
            else
            {
                int extraSecondsQuotient = extraSeconds / 10;
                for (int i = 0; i < extraSecondsQuotient * 2 - 1; i++)
                {
                    _breathingLengths.Add(5);
                }
                if (extraSeconds % 10 > 0)
                {
                    _breathingLengths.Add(extraSeconds % 10 + 5);
                }
                else
                {
                    _breathingLengths.Add(5);
                }
            }
        }
        Console.WriteLine();
        if (_breathingLengths.Count >= 2)
            for (int i = 0; i < _breathingLengths.Count; i ++)
            {
                if (i % 2 == 0)
                {
                    Console.Write("\nBreathe in... ");
                    ShowDescendingNumbers(_breathingLengths[i]);
                }
                else
                {
                    Console.Write("\nNow breathe out... ");
                    ShowDescendingNumbers(_breathingLengths[i]);
                    Console.WriteLine();
                }
            }
        else
        {
            Console.Write("Breath in... ");
            ShowDescendingNumbers(seconds);
        }
    }

    private void DetermineBreathingLength(int seconds)
    {
        switch (seconds)
        {
            case <= 2:
                _breathingLengths = [seconds];
                break;
            case <= 7:
                double dividedSeconds = seconds / 2.0;
                int breatheIn = (int)Math.Floor(dividedSeconds);
                int breatheOut = (int)Math.Ceiling(dividedSeconds);
                _breathingLengths = [breatheIn, breatheOut];
                break;
            case <= 11:
                dividedSeconds = (seconds - 4) / 2.0;
                breatheIn = (int)Math.Floor(dividedSeconds);
                breatheOut = (int)Math.Ceiling(dividedSeconds);
                _breathingLengths = [2, 2, breatheIn, breatheOut];
                break;
            case <= 14:
                dividedSeconds = (seconds - 5) / 2.0;
                breatheIn = (int)Math.Floor(dividedSeconds);
                breatheOut = (int)Math.Ceiling(dividedSeconds);
                _breathingLengths = [2, 3, breatheIn, breatheOut];
                break;
            case 15:
                _breathingLengths = [2, 4, 4, 5];
                break;
            case 16:
                _breathingLengths = [2, 4, 4, 6];
                break;
            case 17:
                _breathingLengths = [2, 3, 2, 3, 3, 4];
                break;
            case <= 20:
                dividedSeconds = (seconds - 11) / 2.0;
                breatheIn = (int)Math.Floor(dividedSeconds);
                breatheOut = (int)Math.Ceiling(dividedSeconds);
                _breathingLengths = [2, 3, 3, 3, breatheIn, breatheOut];
                break;
            case <= 23:
                dividedSeconds = (seconds - 12) / 2.0;
                breatheIn = (int)Math.Floor(dividedSeconds);
                breatheOut = (int)Math.Ceiling(dividedSeconds);
                _breathingLengths = [2, 3, 3, 4, breatheIn, breatheOut];
                break;
            case <= 26:
                dividedSeconds = (seconds - 18) / 2.0;
                breatheOut = (int)Math.Floor(dividedSeconds);
                breatheIn = (int)Math.Ceiling(dividedSeconds);
                _breathingLengths = [2, breatheOut, breatheIn, 5, 5, 6];
                break;
            case 27:
                _breathingLengths = [2, 4, 5, 5, 5, 6];
                break;
            case 28:
                _breathingLengths = [2, 3, 3, 3, 4, 4, 4, 5];
                break;
            case <= 31:
                dividedSeconds = (seconds - 20) / 2.0;
                breatheIn = (int)Math.Floor(dividedSeconds);
                breatheOut = (int)Math.Ceiling(dividedSeconds);
                _breathingLengths = [2, 3, 3, 4, 4, 4, breatheIn, breatheOut];
                break;
            case <= 40:
                dividedSeconds = (seconds - 27) / 2.0;
                breatheIn = (int)Math.Floor(dividedSeconds);
                breatheOut = (int)Math.Ceiling(dividedSeconds);
                _breathingLengths = [2, 3, 3, 3, 3, 4, 4, 5, breatheIn, breatheOut];
                break;
            case <= 49:
                dividedSeconds = (seconds - 36) / 2.0;
                breatheIn = (int)Math.Floor(dividedSeconds);
                breatheOut = (int)Math.Ceiling(dividedSeconds);
                _breathingLengths = [2, 3, 3, 3, 4, 4, 4, 4, 4, 5, breatheIn, breatheOut];
                break;
            case <= 56:
                dividedSeconds = (seconds - 43) / 2.0;
                breatheIn = (int)Math.Floor(dividedSeconds);
                breatheOut = (int)Math.Ceiling(dividedSeconds);
                _breathingLengths = [2, 3, 3, 4, 4, 5, 5, 7, 5, 5, breatheIn, breatheOut];
                break;
            case <= 60:
                dividedSeconds = (seconds - 48) / 2.0;
                breatheIn = (int)Math.Floor(dividedSeconds);
                breatheOut = (int)Math.Ceiling(dividedSeconds);
                _breathingLengths = [2, 3, 3, 3, 3, 4, 4, 5, 5, 5, 5, 6, breatheIn, breatheOut];
                break;
        }
    }
}
// case 8:
//     _breathingLengths = [2, 2, 2, 2];
//     break;
// case 9:
//     _breathingLengths = [2, 2, 2, 3];
//     break;
// case 10:
//     _breathingLengths = [2, 2, 3, 3];
//     break;
// case 11:
//     _breathingLengths = [2, 2, 3, 4];
//     break;

// case 12:
//     _breathingLengths = [2, 3, 3, 4];
//     break;
// case 13:
//     _breathingLengths = [2, 3, 4, 4];
//     break;
// case 14:
//     _breathingLengths = [2, 3, 4, 5];
//     break;