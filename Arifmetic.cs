using System;
using Genetic;

public class Arifmetic : State{
    private int A;
    public int GetA => A;
    private int B;
    public int GetB => B;
    private int C;
    public int GetC => C;
    private int D;
    public int GetD => D;

    public Arifmetic(int a, int b, int c, int d){
        A = Math.Max(a,1);
        B = Math.Max(b,1);
        C = Math.Max(c,1);
        D = Math.Max(d,1);
    }

    private int GetValue(int val) => val < 0 ? -1 * val : val;  

    public override int Measure(){
        return (GetValue(A) / GetValue(B) + GetValue(C) / GetValue(D)) * 1000 ;
    }
}

public class ArifmeticProperty: GeneticPropertyState<Arifmetic>{
    private readonly Random random;

    public ArifmeticProperty(){
        random = new Random();
    }

    public override Arifmetic NewState(Arifmetic state){
        return new Arifmetic(
            random.Next(1,100)
            , random.Next(1,100)
            , random.Next(1,100)
            , random.Next(1,100)
            );
    }
    
    public override Arifmetic Crossing(Arifmetic left, Arifmetic right){
        return new Arifmetic(
            left.GetA
            , left.GetB
            , right.GetC
            , right.GetD
            );
    }
    public override Arifmetic Mutation(Arifmetic state){
        return new Arifmetic(
            state.GetA + random.Next(-1,1)
            , state.GetB + random.Next(-1,1)
            , state.GetC + random.Next(-1,1)
            , state.GetD + random.Next(-1,1)
        );
    }
}