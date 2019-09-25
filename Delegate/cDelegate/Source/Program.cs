namespace cDelegate {

	class Entrance{
		static void Main(string[] args) {

            Delegator delegator = new Delegator();
            delegator.dele();
            delegator.actn();
            delegator.act2();
            delegator.func();

            //MultiDelegate md = new MultiDelegate();
            ////md.TestSingle();
            //md.TestMulti();

            //Invoke iv = new Invoke();
            //iv.start();
        }
	}
}
