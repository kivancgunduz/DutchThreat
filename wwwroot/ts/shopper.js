var Shopper = /** @class */ (function () {
    function Shopper(firstName, lastName) {
        this.firstName = firstName;
        this.lastName = lastName;
    }
    Shopper.prototype.showname = function () {
        alert(this.firstName + " " + this.lastName);
    };
    return Shopper;
}());
//# sourceMappingURL=shopper.js.map