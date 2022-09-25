function BigUser() {

  this.name = "Вася";

  return { name: "Godzilla" };  // <-- возвращает этот объект
}

alert( new BigUser().name );  