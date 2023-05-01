$(document).ready(function () {
    // carousel
    var tl = anime.timeline({
        loop: true,
    });
    //slide 1
    tl.add({
        targets: '.slide1',
        rotateY: [
            { value: 90, duration: 2000, delay: 16000 }
        ]
    });
    tl.add({
        targets: '.slide1 img ',
        opacity: 1,
        width: ['0%', '100%'],
        height: ['0%', '100%'],
        duration: 4000
    }, '-=16000');
    tl.add({
        targets: '.slide1 h1',
        translateX: '100%',
        opacity: [0, 1],
        duration: 4000
    }, '-=12000');
    tl.add({
        targets: '.slide1 p',
        translateX: '100%',
        translateY: 100,
        opacity: 1,
        duration: 4000
    }, '-=8000');
    tl.add({
        targets: '.slide1 * ',
        opacity: 0,
        duration: 2000
    }, '-=2000');
    //slide 2
    tl.add({
        targets: '.slide2',
        rotateY: [
            { value: -90, duration: 0 },
            { value: 0, duration: 2000 },
            { value: 90, duration: 2000, delay: 16000 }
        ]
    }, '-=2000');
    tl.add({
        targets: '.slide2 img ',
        scale: [1.05, 1],
        opacity: 1,
        duration: 4000
    }, '-=16000');
    tl.add({
        targets: '.slide2 h1',
        translateX: '100%',
        opacity: [0, 1],
        duration: 4000
    }, '-=12000');
    tl.add({
        targets: '.slide2 p',
        translateX: '100%',
        translateY: 100,
        rotateZ: 360,
        scale: [0, 1],
        opacity: 1,
        duration: 4000
    }, '-=8000');
    tl.add({
        targets: '.slide2 * ',
        opacity: 0,
        duration: 2000
    }, '-=2000');
    //slide 3
    tl.add({
        targets: '.slide3',
        rotateY: [
            { value: -90, duration: 0 },
            { value: 0, duration: 2000 },
            { value: 90, duration: 2000, delay: 16000 }
        ]
    }, '-=2000');
    tl.add({
        targets: '.slide3 img ',
        scale: [1.05, 1],
        rotateZ: 360,
        opacity: 1,
        duration: 4000
    }, '-=16000');
    tl.add({
        targets: '.slide3 h1',
        translateX: ['100%', '90%'],
        scaleX: [1, 1.5, 1],
        opacity: [0, 1],
        duration: 4000
    }, '-=12000');
    tl.add({
        targets: '.slide3 p',
        translateX: '100%',
        translateY: 100,
        opacity: 1,
        duration: 4000
    }, '-=8000');
    tl.add({
        targets: '.slide3 * ',
        opacity: 0,
        duration: 2000
    }, '-=2000');
    //slide 4
    tl.add({
        targets: '.slide4',
        rotateY: [
            { value: -90, duration: 0 },
            { value: 0, duration: 2000 },
            { value: 0, duration: 2000, delay: 16000 }
        ]
    }, '-=2000');
    tl.add({
        targets: '.slide4 img ',
        scale: [0, 1],
        opacity: 1,
        duration: 4000
    }, '-=16000');
    tl.add({
        targets: '.slide4 h1',
        translateX: '100%',
        opacity: [0, 1],
        scale: [1.5, 1],
        duration: 4000
    }, '-=12000');
    tl.add({
        targets: '.slide4 p',
        translateX: '100%',
        translateY: 100,
        opacity: 1,
        duration: 4000
    }, '-=8000');
    tl.add({
        targets: '.slide4 * ',
        opacity: 0,
        duration: 2000
    }, '-=2000');
    //slide 1 again
    tl.add({
        targets: '.slide1',
        rotateY: [
            { value: -90 },
            { value: 0, duration: 2000 }
        ]
    }, '-=2000');
});
