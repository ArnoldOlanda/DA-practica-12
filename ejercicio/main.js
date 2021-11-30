addEvent(window, "load", inicializarEventos, false);
function inicializarEventos() {
  var ob;
  ob = document.getElementById("enlace");
  addEvent(ob, "click", presionEnlace, false);
}
function presionEnlace(e) {
  if (window.event) {
    window.event.returnValue = false;
    var url = window.event.srcElement.getAttribute("href");
    cargarVenta(url);
  } else if (e) {
    e.preventDefault();
    var url = e.target.getAttribute("href");
    cargarVenta(url);
  }
}
var conexion1;
function cargarVenta(url) {
  if (url == "") {
    return;
  }
  conexion1 = crearXMLHttpRequest();
  conexion1.onreadystatechange = procesarEventos;
  conexion1.open("GET", url, true);
  conexion1.send(null);
}
function procesarEventos() {
  var tablaDetalles = document.getElementById("tablaDetalles");
  if (conexion1.readyState == 4) {
    tablaDetalles.innerHTML = conexion1.responseText;
  } else {
    tablaDetalles.innerHTML = "Cargando...";
  }
}

function addEvent(elemento, nomevento, funcion, captura) {
  if (elemento.attachEvent) {
    elemento.attachEvent("on" + nomevento, funcion);
    return true;
  } else if (elemento.addEventListener) {
    elemento.addEventListener(nomevento, funcion, captura);
    return true;
  } else return false;
}
function crearXMLHttpRequest() {
  var xmlHttp = null;
  if (window.ActiveXObject) xmlHttp = new ActiveXObject("Microsoft.XMLHTTP");
  else if (window.XMLHttpRequest) xmlHttp = new XMLHttpRequest();
  return xmlHttp;
}
