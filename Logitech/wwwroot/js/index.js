//const productList = [
//    {
//        img: 'https://cf.shopee.vn/file/59ccaf34cc3dbb67972d0b8901a89531_tn',
//        name: 'Chuột không dây LOGITECH B137',
//        priceOld: 999000,
//        priceNew: 999000,
//        sold: 1700,
//        salePrecent: 59,
//        averageStar: 4.3,
//    },
//    {
//        img: 'https://cf.shopee.vn/file/73660e810147e69071b04e84ad609400_tn',
//        name: 'Bàn phím Bluetooth Logitech K380 Multi-Device - Kết nối Bluetooth cùng lúc 3 thiết bị',
//        priceOld: 699000,
//        priceNew: 599000,
//        sold: 7000,
//        salePrecent: 13,
//        averageStar: 4.6,
//    },
//    {
//        img: 'https://cf.shopee.vn/file/59ccaf34cc3dbb67972d0b8901a89531_tn',
//        name: 'Chuột không dây LOGITECH B137',
//        priceOld: 999000,
//        priceNew: 999000,
//        sold: 1700,
//        salePrecent: 59,
//        averageStar: 4.3,
//    },
//    {
//        img: 'https://cf.shopee.vn/file/73660e810147e69071b04e84ad609400_tn',
//        name: 'Bàn phím Bluetooth Logitech K380 Multi-Device - Kết nối Bluetooth cùng lúc 3 thiết bị',
//        priceOld: 699000,
//        priceNew: 599000,
//        sold: 7000,
//        salePrecent: 13,
//        averageStar: 4.6,
//    },
//]

const womanList = [];

const generateProduct = (param) => {
    const column = document.createElement("div");
    const productItem = document.createElement("a");
    const productItemImage = document.createElement("div");
    const productItemContent = document.createElement("div");
    const productItemName = document.createElement("div");
    const productItemPrice = document.createElement("div");
    const productItemEstimate = document.createElement("div");
    const productItemRating = document.createElement("div");
    const productItemSold = document.createElement("div");
    const productItemSoldNumber = document.createElement("span");
    const productItemMall = document.createElement("div");
    const productItemSallOff = document.createElement("div");
    const productItemSallOffText = document.createElement("div");
    const productItemSallOffLabel = document.createElement("div");

    column.appendChild(productItem);
    productItem.appendChild(productItemImage);
    productItem.appendChild(productItemContent);
    productItemContent.appendChild(productItemName);
    productItemContent.appendChild(productItemPrice);
    productItemContent.appendChild(productItemEstimate);
    productItemEstimate.appendChild(productItemRating);
    productItemEstimate.appendChild(productItemSold);
    productItemSold.appendChild(productItemSoldNumber);
    productItemContent.appendChild(productItemMall);
    productItemMall.appendChild(document.createElement("span"));
    productItemContent.appendChild(productItemSallOff);
    productItemSallOff.appendChild(productItemSallOffText);
    productItemSallOff.appendChild(productItemSallOffLabel);

    column.className += "grid__col-2-5";
    productItem.className += "product-item";
    productItemImage.className += "product-item__img";
    productItemContent.className += "product-item__content";
    productItemName.className += "product-item__name";
    productItemPrice.className += "product-item__price";
    productItemEstimate.className += "product-item__estimate";
    productItemRating.className += "product-item__rating";
    productItemSold.className += "product-item__sold";
    productItemSoldNumber.className += "product-item__sold-number";
    productItemMall.className += "product-item__mall";
    productItemSallOff.className += "product-item__sale-off";
    productItemSallOffText.className += "product-item__sale-off-text";
    productItemSallOffLabel.className += "product-item__sale-off-label";

    productItem.href = "#";
    productItemImage.style.backgroundImage = "url('" + param.img + "')";
    productItemName.innerHTML = param.name;
    productItemSold.innerHTML = "Đã bán " + convertSold(param.sold);
    productItemMall.querySelector(".product-item__mall>span").innerHTML = "Mall";
    productItemSallOffText.innerHTML = param.salePrecent + "%";
    productItemSallOffLabel.innerHTML = "GIẢM";

    //#region  Xử lý Price
    if (param.priceOld != param.priceNew) {
        const productItemPriceOld = document.createElement("span");
        productItemPrice.appendChild(productItemPriceOld);
        productItemPriceOld.className += "product-item__price-old";
        productItemPriceOld.innerHTML = param.priceOld.toLocaleString() + "đ";

        const productItemPriceNew = document.createElement("span");
        productItemPrice.appendChild(productItemPriceNew);
        productItemPriceNew.className += "product-item__price-new";
        productItemPriceNew.innerHTML = param.priceNew.toLocaleString() + "đ";
    } else {
        const productItemPriceNew = document.createElement("span");
        productItemPrice.appendChild(productItemPriceNew);
        productItemPriceNew.className += "product-item__price-new";
        productItemPriceNew.innerHTML = param.priceNew.toLocaleString() + "đ";
    }
    //#endregion

    //#region Xử lý Rating
    var averageStar = Math.round(param.averageStar);
    for (let j = 0; j < averageStar; j++) {
        const productItemRatingStar = document.createElement("i");
        productItemRating.appendChild(productItemRatingStar);
        productItemRatingStar.className += "fas fa-star product-item__rating-star--gold";
    }
    for (let i = 0; i < 5 - averageStar; i++) {
        const productItemRatingStar = document.createElement("i");
        productItemRating.appendChild(productItemRatingStar);
        productItemRatingStar.className += "fas fa-star";
    }
    //#endregion


    return column;
};

productList.forEach((product) => womanList.push(generateProduct(product)));

const womanProductContainer = document.getElementById(
    "woman-product"
);

womanList.forEach((element) => womanProductContainer.appendChild(element));

function convertSold(sold) {
    if (sold >= 1000) {
        sold = (sold / 1000).toFixed(1).replace(".", ",") + "k";

        if (sold[sold.toString().indexOf(",") + 1] == "0") {
            sold = sold.replace(',0', '');
        }
    }
    return sold;
}
