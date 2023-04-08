public class Dog {
        private String name;
        private int age;
        private int weight;

        public Dog(String name, int age, int weight) {
            this.name = name;
            this.age = age;
            this.weight = weight;
        }

        public Dog() {}

        public void sayGav() { System.out.println("Гав-гав!"); }

        public String getName() { return name; }

        public void setName(String name) { this.name = name; }

        public int getAge() { return age; }

        public void setAge(int age) { this.age = age; }

        public int getWeight() { return weight; }

        public void setWeight(int weight) { this.weight = weight; }
}