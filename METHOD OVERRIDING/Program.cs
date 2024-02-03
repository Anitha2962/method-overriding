
class Animal
{
    public virtual void animalsound()
    {
        Console.WriteLine("the animal make a sound");
    }
    
}
class pig:Animal
{
    public override void animalsound()
    {
        Console.WriteLine("the pig says wee weee");
    }
}

class program
{
    static void main(string[] args)
    {
        Animal myanimal = new Animal();
        Animal mypig= new pig();
        myanimal.animalsound();
        mypig.animalsound();
    }
}