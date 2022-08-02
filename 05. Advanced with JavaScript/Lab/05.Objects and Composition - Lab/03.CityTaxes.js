function solve(name, population, treasury) {
    const city = {
        name,
        population,
        treasury,
        taxRate: 10,

        collectTaxes() {
            this.treasury += this.population * this.taxRate;
        },
        applyGrowth(percent) {
            this.population += Math.floor(this.population * percent / 100);
        },
        applyRecession(percent) {
            this.treasury -= Math.floor(this.treasury * percent / 100);
        },
    }

    return city;
}

const city_1 =
    solve('Tortuga',
        7000,
        15000);
console.log(city_1);

console.log('-----');

const city_2 =
    solve('Tortuga',
        7000,
        15000);
city_2.collectTaxes();
console.log(city_2.treasury);
city_2.applyGrowth(5);
console.log(city_2.population);