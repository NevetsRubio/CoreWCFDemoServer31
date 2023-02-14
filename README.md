# CoreWCFDemoServer31

## What methods are available
* Echo
  * Returns string of whatever string you pass in.
* ComplexEcho
  * Returns _ComplexEcho_ response which contains string of whatever you pass in.
* FailEcho
  * Returns a _FaultException_ of type _EchoFault_.
* DependencyInjectionExample
  * Returns string of whatever string you pass in. But does two different dependency injections and logs things.


## How to use

1. Run the project
2. Go to http://localhost:5031/EchoService/basichttp?wsdl
3. Use Extension Wizdler to make specific SOAP calls.
