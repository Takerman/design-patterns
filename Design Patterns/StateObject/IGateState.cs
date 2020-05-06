namespace StateObject
{
    public interface GateState
    {
        void Enter();

        void Pay();

        void PayFailed();

        void PayOn();
    }
}