function personAndTeacher() {
    class Person {
        constructor(name, email) {
            this.name = name;
            this.email = email;
        }
    }

    class Teacher extends Person {
        constructor(name, email, subject) {
            super(name, email); //we call the parent constructor from class Person
            this.subject = subject;
        }
    }

    return {
        Person,
        Teacher
    }
}
//class Person and class Teacher extend Person from 01.Person.js