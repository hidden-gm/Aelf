using AElf.Sdk.CSharp.State;

namespace AElf.Contracts.BuildersDAO
{
    // The state class is access the blockchain state
    public class BuildersDAOState : ContractState 
    {
        // A state that holds string value
        public StringState Message { get; set; }
    }
}