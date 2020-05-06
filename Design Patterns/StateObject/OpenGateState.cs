namespace StateObject
{
    public class OpenGateState : GateState
    {
        public OpenGateState(Gate gate)
        {
            this.Gate = gate;
        }

        public Gate Gate { get; }

        public void Enter()
        {
            throw new System.NotImplementedException();
        }

        public void Pay()
        {
            throw new System.NotImplementedException();
        }

        public void PayFailed()
        {
            throw new System.NotImplementedException();
        }

        public void PayOn()
        {
            // let the user in
            this.Gate.ChangeState(new CloseGateState());
        }
    }
}