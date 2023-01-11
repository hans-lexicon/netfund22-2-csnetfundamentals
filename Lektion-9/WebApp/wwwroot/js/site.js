if (document.body.clientHeight < window.innerHeight) {
    console.log('sidan är mindre')
    document.getElementById('footer').style.position = 'fixed'
} else {
    console.log('sidan är större')
}
    