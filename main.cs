using System;

class Program {
  
  public static void Main (string[] args) {
    //initalizing song lyrics to arrays
    string [] song1 = {"Oh,well imagine", "As I'm pacing the pews in a church corridor", "And I can't help but to hear", "No I can't help but to hear an exchanging of words..."};
    
    string [] song2 = {"Oh-oh-oh-oh-oh,", "oh-oh-oh-oh,", "oh-oh-oh", "Caught in a bad romance..."};
    
    string [] song3 = {"Coming out of my cage", "And I've been doing just fine", "Gotta gotta be down", "Because I want it all"};
    
    string [] song4 = {"Now, this is a story all about how", "My life got flipped turned upside down", "And I'd like to take a minute", "Just sit right there", "I'll tell you how I became the prince of a town called Bel-Air"};

  //printing out song lyrics from each array then a blank ling to seperate each song
    for(int i = 0; i < song1.Length; i++)
    {
      Console.WriteLine(song1[i]);
    }
    Console.WriteLine();

    for(int i = 0; i < song2.Length; i++)
    {
      Console.WriteLine(song2[i]);
    }
    Console.WriteLine();

    for(int i = 0; i < song3.Length; i++)
    {
      Console.WriteLine(song3[i]);
    }
    Console.WriteLine();

    for(int i = 0; i < song4.Length; i++)
    {
      Console.WriteLine(song4[i]);
    }
  }
}