# Keys

Keys are the basic components in the JSON file, used to specify which assets in Roblox Studio will be replaced.

Each key is structured as a `"path":"url"` pair:
- The `path` is the location of the asset in the Roblox Studio directory.
- The `url` is the web address from which rilo downloads the replacement asset.

For example:
```json
{
  "textures\\Cursors\\KeyboardMouse\\ArrowCursor.png": "https://cdn.freebiesupply.com/logos/large/2x/firefox-logo-png-transparent.png"
}
```
In this case, rilo will replace the `ArrowCursor.png` in the `KeyboardMouse` folder with the image located at the specified URL.

> [!NOTE]  
> rilo is built in a way, where double backslashes are required in the `path` value when going through folders.
>
> e.g. `textures\Cursors\` should be `textures\\Cursors\\`

## Backing up assets using keys

When rilo processes the JSON file, it backs up the original assets before replacing them. For each `path` in the keys, rilo:
1. Creates a backup of the file by appending `._backup` to its name. For example:
   ```
   textures\\Cursors\\KeyboardMouse\\ArrowCursor.png -> textures\\Cursors\\KeyboardMouse\\ArrowCursor._backup.png
   ```
2. Downloads the image from the `url` provided.
3. Saves the downloaded file in the directory specified by the `path`, renaming it to the original file’s name (e.g., `ArrowCursor.png`).

This process continues for all keys until all assets have been backed up and replaced.

Then, you can view the backed up assets and the newly downloaded assets straight in Windows Explorer by just going to the path.
