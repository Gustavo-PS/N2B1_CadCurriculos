
var mask = {

    //Init
    init: function (o, f) {
        v_obj = o;
        v_fun = f;

        setTimeout("mask.execmasc()", 1);
    },

    //ExecMasc
    execmasc: function () {
        v_obj.value = v_fun(v_obj.value)
    },

    //Cep
    cep: function (v) {
        v = v.replace(/\D/g, "");
        v = v.replace(/^(\d{5})(\d)/, "$1-$2");

        document.getElementById("cep").maxLength = "9";

        return v;
    },

    //Tel
    tel: function (v) {
        v = v.replace(/\D/g, "");
        v = v.replace(/^(\d{2})(\d)/g, "($1) $2");
        v = v.replace(/(\d)(\d{4})$/, "$1-$2");

        document.getElementById("tel").maxLength = "15";

        return v;
    },

    //CPF
    cpf: function (v) {
        v = v.replace(/\D/g, "");
        v = v.replace(/(\d{3})(\d)/, "$1.$2");
        v = v.replace(/(\d{3})(\d)/, "$1.$2");
        v = v.replace(/(\d{3})(\d{1,2})$/, "$1-$2");

        document.getElementById("cpf").maxLength = "14";

        return v;
    },

    //Num
    num: function (v) {
        v = v.replace(/\D/g, "");

        return v;
    },

    //Date
    date: function (v) {
        v = v.replace(/\D/g, "");
        v = v.replace(/(\d{2})(\d)/, "$1/$2");
        v = v.replace(/(\d{2})(\d)/, "$1/$2");

        v = v.replace(/(\d{2})(\d{2})$/, "$1$2");

        return v;
    },

}

/*
// Adicionar/Remover
var countAR = 2;

function duplicarCampos() {
    var clone = document.getElementById('origem').cloneNode(true);
    var destino = document.getElementById('destino');
    destino.appendChild(clone);

    var camposClonados = clone.getElementsByTagName('input');
    var camposClonadosS = clone.getElementsByTagName('select');

    for (i = 0; i < camposClonados.length; i++) {
        camposClonados[i].value = '';
        console.log(camposClonados[i].id + countAR);
        camposClonados[i].id = camposClonados[i].id + countAR;
        console.log(camposClonados[i].id);
    }

    for (i = 0; i < camposClonadosS.length; i++) {
        camposClonadosS[i].value = '';
        console.log(camposClonadosS[i].id + countAR);
    }

    countAR++;
}

function removerCampos(id) {
    var node1 = document.getElementById('destino');
    node1.removeChild(node1.childNodes[0]);
    countAR = countAR - 1;
}
*/
