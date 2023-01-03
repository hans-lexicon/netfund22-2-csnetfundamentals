const getProducts = async () => {
    const result = await fetch("https://localhost:7265/api/Products")
    const products = await result.json()


    for (let product of products) {
        document.getElementById('productList').innerHTML += 
        `
        <div class="col">
            <div class="card h-100 shadow">
                <div class="card-body">
                    <h6 class="card-title"><span class="text-muted" style="font-size: 0.6em">${product.vendor.toUpperCase()}</span> ${product.name}</h6>
                    <p class="card-text">${product.description}</p>
                </div>
            </div>
        </div>
        `
    }
}


const addProduct = async (event) => {
    event.preventDefault()

    const product = {
        id: Number(event.target[0].value),
        name: event.target[1].value,
        vendor: event.target[2].value,
        description: event.target[3].value,
        price: Number(event.target[4].value)
    }

    console.log(JSON.stringify(product))

    await fetch("https://localhost:7265/api/Products", {
        method: 'post',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(product)
    })

    window.location.replace('index.html')
}