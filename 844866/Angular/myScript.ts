//console.log("Hello from Typescript");
//DataTypes
/*let mystring:string;
let myNumber:number;
let myStatus:boolean;
mystring="TypeScript"
myNumber=120;
myStatus=true;
console.log(mystring);
console.log(myNumber);
console.log(myStatus);
*/
//Use of operators and functions
/*let myData:any;
myData="Hello"+" "+"Welcome TypeScript";
console.log(myData);
myData=12+23;
console.log(myData);
let myString:string;
myString="Welcome to Chennai";
console.log(myString.slice(0,3));
let myNumber:number;
myNumber=100;
console.log(myNumber.toString()+"my result");
*/
//Arrays
/*
let mysArray:Array<string>
let mynArray:Array<number>
//let mysArray:string[];
//let mynArray:number[];
let mybArray:Boolean;
mysArray=["Hello","TypeScript"];
mynArray=[1,2,3,4];
console.log(mysArray);
console.log(mynArray);
console.log(mynArray[1]);
for(var n=0;n<mynArray.length;n++)
{
    console.log(mynArray[n]);
}
mysArray.forEach(function(value)
{console.log(value);})
*/
//tuple and void
/*
let myTuple:[string,number,number]
myTuple=["TypeScript",1,4];
console.log(myTuple);
let myvar:void;
myvar=undefined;
console.log(myvar);
let myvar1=null;
myvar1=null;
console.log(myvar1);
console.log(myTuple.pop());
myTuple.push(24);
console.log(myTuple);
*/
//Enum 
/*
enum myEnum{sunday=0,monday,tuesday,wednesday};
console.log(myEnum.tuesday);
//functions
function myfunction(num1:number,num2:number):number
{
    return num1+num2;
}
console.log(myfunction(23,78));
function addfunction(num1:any,num2:any):any
{
return num1+num2;
}
console.log(addfunction("hi",true));
function addNumber(num1:any,num2:any):number
{
    if(typeof(num1)=='string' && typeof(num2)=='string')
    {
        num1=parseInt(num1);
        num2=parseInt(num2);
        return(num1+num2);
    }
    else
        return num1+num2;
}
console.log(addfunction("23","34"));
function getName(firstname:string,lastname:string)
{
    if(lastname==undefined)
    {
        return firstname;
        
    }
    return(firstname + " "+ lastname);
}
console.log(getName("John","dan"));
*/
//Interface with properties
/*
interface myInterface
{
    Name:string;
    Title:string;
}
function Ifunction(myData:myInterface):string
{
    return (myData.Name+" "+ myData.Title);
}
let dat={Name:"David" ,Title:"Associate"}
console.log(Ifunction(dat));
*/
//base structure of a class
/*
class User
{
    Id:number;
    Name:string;
    Email:string;
    Age:number;
    constructor (id:number,name:string,email:string,age:number)
    {
        this.Id=id;
        this.Name=name;
        this.Email=email;
        this.Age=age;
        console.log("User Created.")
    }
}
let firstUser=new User(1,"Jane","Jane@cts.com",21);
console.log(firstUser.Id+" "+firstUser.Name+" "+firstUser.Age);
*/
//class with functions
/*
class User
{
    //private Id:number;
    //private Name:string;
    //private Email:string;
    //private Age:number;
    protected Id:number;
    protected Name:string;
    protected Email:string;
    protected Age:number;
    constructor (id:number,name:string,email:string,age:number)
    {
        this.Id=id;
        this.Name=name;
        this.Email=email;
        this.Age=age;
        console.log("User Created.")
    }
    register()
    {
        console.log(this.Name+"Successfully Registered");
        console.log(this.Id+" "+this.Name+" "+this.Email+" "+this.Age+" ");
    }
    getAge(id:number):number
    {
        if(this.Id=id)
        return this.Age;
        else
        return 0;
    }
}
let firstUser=new User(1,"Jane","Jane@cts.com",21);
firstUser.register();
console.log(firstUser.getAge(1));
//Inheritance
class AdminUser extends User
{
    Type:string;
    constructor (id:number,name:string,email:string,age:number,type:string)
    {
        super(id,name,email,age);
        this.Type=type;
    }
    displayAdmin()
    {
        console.log("You are"+this.Type+" AdminUser");
        console.log(this.Id+" "+this.Name+" "+this.Email+" "+this.Age+" ");
    }
}
let cUser=new AdminUser(1,"Sri","sri123@gmail.com",22,"Account");
cUser.register();
cUser.displayAdmin();
*/
interface IUser
{
    Id:number;
    Name:string;
    Email:string;
    Age:number;
    Register():void;
    getAge(id:number):number;
}
class User implements IUser
{
    Id:number;
    Name:string;
    Email:string;
    Age:number;
    constructor (id:number,name:string,email:string,age:number)
    {
        this.Id=id;
        this.Name=name;
        this.Email=email;
        this.Age=age;
        console.log("User Created.")
    }
    Register()
    {
        console.log(this.Name+"Successfully Registered");
        console.log(this.Id+" "+this.Name+" "+this.Email+" "+this.Age+" ");
    }
    getAge(id:number):number
    {
        if(this.Id=id)
        return this.Age;
        else
        return 0;
    }
}
let cUser=new User(1,"Sri","sri123@gmail.com",22);
cUser.Register();
console.log(cUser.getAge(2));