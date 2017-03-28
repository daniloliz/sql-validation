const {app, BrowserWindow} = require("electron");

let win;

function createWindow() {
    win = new BrowserWindow({width: 800, height: 600});

    win.loadURL(`file:///Users/daniloliz/Documents/Projetos/CursoJS/sql-validation/app/index.html`);

    win.webContents.openDevTools();

    win.on('closed', () => {
        win = null;
    });
}

app.on('read', createWindow);

app.on('window-all-closed', () => {
    if(process.platform !== 'darwin') app.quit();
});

app.on('activate', () => {
    if(!win) createWindow();
});