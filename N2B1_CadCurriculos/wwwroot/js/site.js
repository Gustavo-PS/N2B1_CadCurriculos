// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


//Input apenas números
function InputNumber(evt) {
    var ch = String.fromCharCode(evt.which)

    if (!(/[0-9]/.test(ch))) {
        evt.preventDefault();
    }
}

//Máscara para CPF
var campoCPF = document.getElementById('cpf');

campoCPF.oninput = function () {
    var cpf = campoCPF.value;

    if (cpf.length == 3 || cpf.length == 7) {
        campoCPF.value += "."
    }

    if (cpf.length == 11) {
        campoCPF.value += "-"
    }
        
}

/*
 function mask_CPF() {
    var cpf = document.getElementById('cpf');

    if (cpf.length == 3 || cpf.length == 7) {
        campoCPF.value += "."
    } else (cpf.length == 11) {
        campoCPF.value += "-"
    }
}
 */