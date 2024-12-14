const form = document.getElementById('formulario')
const sendMail = document.getElementById('Amail')

function handleSubmit (event) {
    event.preventDefault()
    const fd = new FormData(this)

    sendMail.setAttribute(
        'href',
        `mailTo: coljarc@gmail.com?subject=${fd.get('Asunto')}
        &body=Nombre: ${fd.get('Nombre')}%0A%0ACorreo: ${fd.get('Correo')}%0A%0AAsunto: ${fd.get('Asunto')}%0A%0ATeléfono: ${fd.get('Telefono')}%0A%0AMensaje:%0A%0A${fd.get('Mensaje')}%0A%0A`
    )

    sendMail.click()
}

form.addEventListener('submit', handleSubmit)
