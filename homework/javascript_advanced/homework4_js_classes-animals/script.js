class Animal {
    constructor(name, type, age, size, isEaten = false) {
        this.name = name;
        this.type = type.toLowerCase();
        this.age = age;
        this.size = size;
        this.isEaten = isEaten;
    }

    eat(input) {
        // Check if input is an instance of Animal
        if (!(input instanceof Animal)) {
            if (typeof input === "string") {
                console.log(`The animal ${this.name} is eating ${input}.`);
            } else {
                console.log("Invalid target. Not an instance of Animal.");
            }
            return;
        }

        // If the animal is a herbivore, it cannot eat other animals
        if (this.type === "herbivore") {
            console.log(`The animal ${this.name} is a herbivore and does not eat other animals.`);
            return;
        }

        // If the input animal's size is less than half of this animal's size, will eat it
        if (input.size < this.size / 2) {
            input.isEaten = true;
            console.log(`The animal ${this.name} ate the ${input.name}.`);
            return;
        }

        // If the input animal's size is at least twice as large, it is too big to be eaten
        if (input.size >= this.size * 2) {
            console.log(`The animal ${this.name} tried to eat ${input.name} but it was too large.`);
            return;
        }

        // Or just do nothing
        console.log(`The animal ${this.name} decided not to eat ${input.name}.`);
    }
}

// === Example Usage ===
const tiger = new Animal("Tiger", "predator", 5, 10); // carnivore
const rabbit = new Animal("Rabbit", "herbivore", 2, 3);
const elephant = new Animal("Elephant", "herbivore", 10, 25);
const wolf = new Animal("Wolf", "predator", 4, 7); // carnivore

tiger.eat(rabbit);
tiger.eat(elephant);
rabbit.eat(tiger);
wolf.eat("meat");