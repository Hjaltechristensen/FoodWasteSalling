window.getCurrentLocation = () => {
    return new Promise((resolve, reject) => {
        if (!navigator.geolocation) {
            reject('Geolocation ikke understøttet af browseren');
        } else {
            navigator.geolocation.getCurrentPosition(
                (position) => {
                    resolve({
                        latitude: position.coords.latitude,
                        longitude: position.coords.longitude
                    });
                },
                (error) => reject(error.message)
            );
        }
    });
};


window.initMiniMap = (lat, lng) => {
    var map = L.map('miniMap', {
        attributionControl: false,
        zoomControl: false,
        doubleClickZoom: false,
    }).setView([lat, lng], 15);

    L.tileLayer('https://{s}.basemaps.cartocdn.com/light_all/{z}/{x}/{y}{r}.png', {
        attribution: '&copy; <a href="https://carto.com/">CARTO</a>',
        subdomains: 'abcd',
        maxZoom: 19
    }).addTo(map);

    L.marker([lat, lng]).addTo(map);
};

window.initFullMap = (storeLat, storeLng, userLat, userLng) => {
    const map = L.map('fullMap', {
        attributionControl: false,
        zoomControl: false
    }).setView([storeLat, storeLng], 15);

    L.tileLayer('https://server.arcgisonline.com/ArcGIS/rest/services/World_Imagery/MapServer/tile/{z}/{y}/{x}', {
        attribution: 'Tiles &copy; Esri'
    }).addTo(map);

    // Markør for butik
    L.marker([storeLat, storeLng]).addTo(map).bindPopup("Butik");

    // Hvis brugerens lokation findes
    if (userLat !== null && userLng !== null) {
        const userIcon = L.icon({
            iconUrl: 'https://cdn-icons-png.flaticon.com/512/684/684908.png',
            iconSize: [30, 30],
            iconAnchor: [15, 30]
        });

        L.marker([userLat, userLng], { icon: userIcon })
            .addTo(map)
            .bindPopup("Din placering")
            .openPopup();
    }
};
