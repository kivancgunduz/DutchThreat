class Shopper {
    

    constructor(private firstName: string, private lastName: string) {

    }

    showname() {
        alert(`${this.firstName} ${this.lastName}`);
    }
}