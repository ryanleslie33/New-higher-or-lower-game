using System;
using System.Collections.Generic;

namespace Game{
  class Guess
  {
    public int initialValue;
    public int endValue;

    public Guess()
    {
      this.initialValue = 0;
      this.endValue = 100;
    }

      public void RunGuess()
      {
      Random rnd = new Random();
      int randomNumber = rnd.Next(initialValue, endValue);
      Console.WriteLine("Random number " + randomNumber + "  Is your number greater['y', 'n']");
      string stringUserReply = Console.ReadLine();
      if ( stringUserReply == "y" || stringUserReply == "Y")
      {
        initialValue = randomNumber;

      } else
      {
        endValue = randomNumber;
      }

      if( endValue - initialValue <=2 ){
        Console.WriteLine("Your Number is "+ (initialValue + 1));
      }else{
        RunGuess();
      }
      }
    }
}
