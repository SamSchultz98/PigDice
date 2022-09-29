namespace MyPigDice;

public class PigDice
{
    Random random = new();
    private int RollDie()
    {
        return random.Next(1,7);
    }

    public int Play()
    {
        int score = 0;
        int roll;
        while ((roll = RollDie()) != 1){
            score += roll;
        }
        return score;

    }
    
    public int PlayTill(int amountgames)
    {
        int i = 0;
        int highscore = 0;
        while (i <= amountgames){
            i++;
            var iter = Play();
            if (iter > highscore)
            {
                highscore = iter;
            }

        }
    return highscore;

    }

    public long RecordGame(int targetscore)
    {
        long iteration = 0;
        int score = Play();
        while (score < targetscore)
        {
            iteration++;
            score = Play();     //How much memory does this take up?
        }
        return iteration;


    }


    /////////////////////////////////////////////////////////////////////////////////////////
public long ReworkedRecordGame(int targetscore) //This runs without calling the function play again
    {
        long iteration = 0;
        int score1 = Play();
        while (score1 < targetscore)
        {
        iteration++;
            
        int score = 0;
        int roll = 0;
        while ((roll = RollDie()) != 1)
        {
            score += roll;
        }
        score1 = score;

        }
        return iteration;


    }
}