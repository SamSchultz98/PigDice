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
        while (score != targetscore)
        {
            iteration++;
            score = Play();
        }
        return iteration;


    }






















}