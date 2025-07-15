namespace SMSModels {
    public struct NameKey {
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public NameKey(string firstName, string lastName) {
            Firstname = firstName;
            Lastname = lastName;
        }

        public override bool Equals(object obj) {
            return obj is NameKey other
                && Firstname == other.Firstname
                && Lastname == other.Lastname;
        }

        public override int GetHashCode() {
            return HashCode.Combine(Firstname, Lastname);
        }
    }
}
