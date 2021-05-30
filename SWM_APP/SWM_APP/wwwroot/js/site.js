function insertWsrefGetForm() {
    $('#div1').load('http://localhost:56754/insert');
}

function filterWsrefGetForm() {
    $('#div1').load('http://localhost:56754/filterform');
}

function updateWsrefGetForm(id){
    $('#div-'+id).load('http://localhost:56754/update/'+id);
}

function deleteWsrefGetForm(id) {
    $('#div-'+id).load('http://localhost:56754/delete/' + id);
}

function commentsWsrefGetForm(id) {
    $('#div-' + id).load('http://localhost:56754/comments/' + id);
}

function insertCommentsWsrefGetForm(id) {
    $('#div-' + id + '-comments').load('http://localhost:56754/commentsinsert/' + id);

}

function deleteComGetForm(id, idCom) {
    $('#div-' + id + '-comments-' + idCom).load('http://localhost:56754/CommentsGetFormDelete/' + idCom);

}

function updateComGetForm(id, idCom) {
    $('#div-' + id + '-comments-' + idCom).load('http://localhost:56754/CommentsGetFormUpdate/' + idCom);

}

function closeDeleteComGetForm(id) {
    $('#div-' + id + '-comments').load('http://localhost:56754/commentsinsert/' + id);
}


function clearDiv(id) {
    $(id).html("")
}