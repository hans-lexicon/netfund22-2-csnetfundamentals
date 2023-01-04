const currencyFormat = new Intl.NumberFormat('sv-se', { currency: 'SEK', style: 'currency' })
const currencyFormatter = (value) => {
    return currencyFormat.format(value)
}

const getProducts = async () => {

    try {
        const result = await fetch('https://localhost:7162/api/products')
    
        if (result.status = 200) {
            const products = await result.json()
            for (let product of products) {
                console.log(product)
                
                document.getElementById('product-cards').innerHTML += `
                <div class="col">
                    <div class="card">
                        <div class="card-img">
                            <img src="images/${product.imageName}" alt="...">
                            <div class="card-menu d-xl-none">
                                <button class="menu-link"><i class="fa-regular fa-heart"></i></button>
                                <button class="menu-link"><i class="fa-regular fa-code-compare"></i></button>
                                <button class="menu-link"><i class="fa-regular fa-shopping-bag"></i></button>
                            </div>
                            <a class="btn btn-theme btn-card-theme d-xl-none" href="${product.id}">
                                QUICK VIEW
                            </a>
                        </div>
                        <div class="card-body">
                            <p class="card-category">${product.category}</p>
                            <h5 class="card-title">${product.title}</h5>
                            <p class="card-rating">
                                <i class="fa-sharp fa-solid fa-star"></i>
                                <i class="fa-sharp fa-solid fa-star"></i>
                                <i class="fa-sharp fa-solid fa-star"></i>
                                <i class="fa-sharp fa-solid fa-star"></i>
                                <i class="fa-regular fa-star"></i>
                            </p>
                            <p class="card-price">
                                ${currencyFormatter(product.price)}
                            </p>
                        </div>
                    </div>
                </div>              
                `
            }
        } else {
            document.getElementById('product-cards').innerHTML = "Inga produkter kunde hittas"
        }
    }
    catch {
        document.getElementById('product-cards').innerHTML = "Inga produkter kunde hittas"
    }

}