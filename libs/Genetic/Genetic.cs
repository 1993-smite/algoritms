using System.Collections.Generic;
using System;

namespace Genetic{
    public class SortedPopulation<TState> where TState : State {
        private List<TState> population;
        public SortedPopulation(){
            population = new List<TState>();
        }

        public TState GetState(int index) => population[index];

        public void AddState(TState state){
            var index = population
                            .FindIndex(x => x.GetMeasure < state.GetMeasure);
            if (index < 0){
                population
                    .Add(state);
            }  
            else {
                population
                    .Insert(index,state);
            } 
        }
    }

    public class Genetic<TState> where TState : State
    {
        private readonly int populationCount;
        private int getBetterPopulationCount => 20 * populationCount / 100;
        private SortedPopulation<TState> population;
        private GeneticPropertyState<TState> properties;
        private Random random;

        public Genetic(int countPopulation = 100){
            populationCount = countPopulation;
            random = new Random();
        }

        public void SetProperties(TState state = null, GeneticPropertyState<TState> property = null){
            if (property == null)
                throw new ArgumentException("Not valid argument delegate newState");
            if (state == null)
                throw new ArgumentException("Not valid argument state");
            
            population = new SortedPopulation<TState>();
            properties = property;
            InitPopulation(state);
        }

        //new population
        private void InitPopulation(TState state = null){
            for(int i=0; i < populationCount; i++){
                state = properties.NewState(state);
                population.AddState(state);
            }
        }

        //age of genetic iteration
        public void Age(){
            var indexStateRight = random.Next(0,getBetterPopulationCount);
            var indexStateLeft = random.Next(0,getBetterPopulationCount);
            
            var left = population.GetState(indexStateLeft);
            var right = population.GetState(indexStateRight);
            if (indexStateLeft != indexStateRight){
                population
                    .AddState(
                        properties
                            .Crossing(left, right));
            }
            population
                .AddState(properties
                            .Mutation(left));
            
            population
                .AddState(properties
                            .Mutation(right));
        }

        //calc time to age ages
        public State GetAge(int ages){
            for(int i=0; i<ages; i++){
                Age();
            }
            return population.GetState(0);
        }
    }
}