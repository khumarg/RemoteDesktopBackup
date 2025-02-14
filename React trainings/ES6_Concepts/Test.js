// for(let i=1; i<=5; i++) {
//     setTimeout(function(){console.log(i);}, 1000);
// }

// let i = 10;
// const data = 100;
// console.log(data);

// declaring an object

// const customer = {
//     id: 10,
//     name: 'Nikhil',
//     salary: 123456
// }

// // console.log(customer.id + " " + customer.name + " " + customer.salary);

// // customer.name = "Nikhil Govekar";       // this is allowed as the structure of the const object is not changing but the properties inside it are.

// // console.log(customer.id + " " + customer.name + " " + customer.salary);

// var getValue = function() {
//     return 100;
// }

// console.log(getValue());

// var getInfo = () => {
//     return 100;
// }

// console.log(getInfo());

// var tax = (salary, rate) => {
//     return salary * rate;
// }

// console.log('Tax to be paid ' + tax(500000, 0.1));

// console.log(typeof customer);

// const emp = {
//     id: 1,
//     // greet: function() {
//     //     var x = this;
//     //     setTimeout(function() {console.log(x.id)}, 1000);
//     // }

//     greet: function() {
//         setTimeout(() => {
//             console.log(this.id);
//         }, 1000);
//     }
// };

// const person = {
//     firstName: 'Nikhil',
//     lastName: 'Govekar',
//     fullname: function() {
//         console.log(this.firstName + " " + this.lastName);
//     }
// }

// person.fullname();

// emp.greet();

// const customer = {
//     firstName: 'Rose',
//     lastName: 'Allen'
// }

// person.fullname.call(customer);

// const data = person.fullname.bind(customer);
// data()

// let getValue = function(value = 10) {
//     console.log(value);
// }

// getValue();

// let getInfo = function(Salary = 10000, bonus = 2000) {
//     console.log(Salary + bonus);
// }

// let getSal = (salary = 10000, bonus = 2000) => {
//     console.log(salary + bonus);
// }

// getInfo();
// getSal();
// getSal(54000, 4000);
// getSal(undefined, 4000);

// const tax = () => 0.1;

// const getDetails = (salary = 50000, bonus = salary * tax()) => {
//     console.log(salary + bonus);
// }

// console.log(getDetails());
// console.log(getDetails(100000, 10000));
// console.log(getDetails(75000))
// console.log(getDetails(undefined, 10000))

// function Add(...args) {
//     let sum = 0;

//     for(let a of args) {
//         sum += a;
//     }
//     return sum;
// }

// let x = Add(4, 9, 10, 16, 25, 36, 40);

// console.log(x);

// let display = function() {
//     for(let x in arguments) {
//         console.log(x + " - " + arguments[x]);
//     }
// }

// display("Red");
// display("Red", "Yellow");
// display("Red", "Yellow", "Green");

// const colours = ['Red', 'Yellow', 'Green']

// console.log(colours);
// console.log(...colours);

// const q1 = ["Jan", "Feb", "Mar"];
// const q2 = ["Apr", "May", "Jun"];
// const q3 = ["Jul", "Aug", "Sep"];
// const q4 = ["Oct", "Nov", "Dec"];

// const year = [...q1, ...q2, ...q3, ...q4];

// console.log(year)
// console.log(...year)

// let x = Math.max(10, 4, 6, 20, 17, 3);
// console.log(x);

// let numbers = [10, 4, 6, 20, 17, 3]

// let x = Math.max(...numbers);
// console.log(x);

// let firstName = "Vicky"
// let lastName = "Malhotra"

// const customer = {
//     firstName: fName,
//     lastName: lName
// }

// const customer = {
//     firstName,
//     lastName
// }

// console.log(customer.firstName + " " + customer.lastName);

// function getData (firstName, lastName, age) {
//     let fullname = firstName + " " + lastName;

//     return{
//         firstName,
//         lastName,
//         fullname,
//         isSenior() {
//             return age > 60;
//         }
//     }
// }

// let emp = getData("Nikhil", "Govekar", 90);

// console.log(emp);
// console.log(emp.isSenior());

// let ln = "Last Name"

// let player = {
//     "first name": "Sachin",
//     [ln]: "Tendulkar"
// }

// console.log(player["first name"] + " " + player[ln]);

// let employee = ['nikhil', 'govekar', 'engineer']

// let employee = ['nikhil', 'govekar']

// let [firstName, lastName, designation] = employee;
// let [ , , designation] = employ

// console.log(firstName);
// console.log(lastName);
// console.log(designation);

// let [firstName, ...info] = employee

// console.log(firstName)
// console.log(info)
// console.log(...info)
// console.log(employee)

const employee = {
    id: 1,
    firstName: 'Nikhil',
    lastName: 'Govekar',
    designation: 'Trainer'
}

let {id, firstName, lastName, designation: desg} = employee

console.log(id)
console.log(firstName)
console.log(lastName)
console.log(desg)

let user = 'nikhil'
let greet = `Welcome ${user} to ES6`
console.log(greet)