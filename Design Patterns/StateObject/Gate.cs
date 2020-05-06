namespace StateObject
{
    // I think This implementation of StatePattern is not good and neeeds to be 
    // implemented in different way
    public class Gate
    {
        public Gate(GateState gateState)
        {
            this.GateState = gateState;
        }

        public GateState GateState { get; set; }

        public void Enter()
        {
            this.GateState.Enter();
        }

        public void Pay()
        {
            this.GateState.Pay();
        }

        public void PayFailed()
        {
            this.GateState.PayFailed();
        }

        public void PayOn()
        {
            this.GateState.PayOn();
        }

        public void ChangeState(GateState gateState)
        {
            this.GateState = gateState;
        }
    }
}