namespace Genetic{
    interface ICrossing<T>{
        T Crossing(T left, T right);
    }

    interface IMutation<T>{
        T Mutation(T state);
    }

    public abstract class GeneticPropertyState<TState> : ICrossing<TState>, IMutation<TState> where TState : State {
        public abstract TState NewState(TState state);
        public abstract TState Crossing(TState left, TState right);
        public abstract TState Mutation(TState state);
        
    }
}