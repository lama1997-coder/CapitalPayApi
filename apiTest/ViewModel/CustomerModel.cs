namespace apiTest.ViewModel
{
    public class CustomerModel
    {

        public string token { get; set; }
        public long CreationTime { get; set; }
            public long ModifiedTime { get; set; }
            public string Id { get; set; }
            public string CustomerNumber { get; set; }
            public PrimaryPerson PrimaryPerson { get; set; }
            public int SecurityLevel { get; set; }
            public string Language { get; set; }
            public string HomeCurrency { get; set; }
            public string ProgramName { get; set; }
            public string FeePlanName { get; set; }

      
    }
}
