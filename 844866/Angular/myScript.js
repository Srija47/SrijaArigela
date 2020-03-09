var User = /** @class */ (function () {
    function User(id, name, email, age) {
        this.Id = id;
        this.Name = name;
        this.Email = email;
        this.Age = age;
        console.log("User Created.");
    }
    User.prototype.Register = function () {
        console.log(this.Name + "Successfully Registered");
        console.log(this.Id + " " + this.Name + " " + this.Email + " " + this.Age + " ");
    };
    User.prototype.getAge = function (id) {
        if (this.Id = id)
            return this.Age;
        else
            return 0;
    };
    return User;
}());
var cUser = new User(1, "Sri", "sri123@gmail.com", 22);
cUser.Register();
console.log(cUser.getAge(2));
