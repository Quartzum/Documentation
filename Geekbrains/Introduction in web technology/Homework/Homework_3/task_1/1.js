let tempCelsia = prompt("Введите температуру в цельсиях: ")
let tempCelsiaRound = Math.round(tempCelsia)
let tempFarengeit = (9/5) * tempCelsiaRound + 32
alert(`Цельсия: ${tempCelsia}, Фаренгейт: ${tempFarengeit}.`)
