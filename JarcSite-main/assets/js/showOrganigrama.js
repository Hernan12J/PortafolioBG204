const openOI = document.getElementById('open');
const modal_containerOI = document.getElementById('modal_container');
const closeOI = document.getElementById('close');

openOI.addEventListener('click',(e)=>{

    console.log("funciona")
    modal_containerOI.classList.add('show'); 
});   

closeOI.addEventListener('click',()=>{

    modal_containerOI.classList.remove('show');
});   