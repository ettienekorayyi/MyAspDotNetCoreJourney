namespace Classes {
    public abstract class Person {
        private int _age;
        private string _name;
        
        public int GetAge() {
            return this._age;
        }
        public void SetAge(int age) {
            this._age = age;
        }

        public string GetName() {
            return this._name;
        }
        public void SetName(string name) {
            this._name = name;
        }
    }
}