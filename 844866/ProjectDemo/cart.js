
const PRODUCTS_KEY = "products";

getProductsFromLocalStorage = () => {
    let cards = [];

    if (localStorage.getItem(PRODUCTS_KEY)) {
        cards = JSON.parse(localStorage.getItem(PRODUCTS_KEY));
    }

    return cards;
}


function addBuyerFormSubmit() {
    alert("hi");

    let cards = getProductsFromLocalStorage();
    //let serialno = document.querySelector("#sno");
    let nameTextBox = document.querySelector("#name1");
    let addrTextBox = document.querySelector("#adr");
    let cityTextBox = document.querySelector("#city");
    let amountTextBox = document.querySelector("#amount");



    let card = {

        name1: nameTextBox.value,
        adr: addrTextBox.value,
        city: cityTextBox.value,
        amount: amountTextBox.value,


    };



    cards.push(card);
    localStorage.setItem(PRODUCTS_KEY, JSON.stringify(cards));
}


function LoadCards() {
    alert("hi");

    let cards = getProductsFromLocalStorage();

    let tableBody = document.querySelector("#crdData");
    for (let card of cards) {
        let crdRow = createProductRow(card);
        tableBody.append(crdRow);
    }
}
function createProductRow(card) {

    let nameCol = document.createElement("td");
    nameCol.textContent = card.name1;

    let addrCol = document.createElement("td");
    addrCol.textContent = card.adr;

    let cityCol = document.createElement("td");
    cityCol.textContent = card.city;

    let amountCol = document.createElement("td");
    amountCol.textContent = card.amount;




    let crdRow = document.createElement("tr");
    crdRow.append(nameCol);
    crdRow.append(addrCol);
    crdRow.append(cityCol);
    crdRow.append(amountCol);
    return crdRow;
}
function f() {
    alert("hi");
}
