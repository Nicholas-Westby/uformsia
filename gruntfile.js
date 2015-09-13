module.exports = function(grunt) {
    grunt.initConfig({
        "pkg": grunt.file.readJSON('package.json'),
        copy: {
            main: {
                files: [
                    {
                        expand: true,
                        //TODO: Configure this to copy files to an Umbraco install.
                        src: ["*"],
                        dest: 'dest/',
                        filter: 'isFile',
                        cwd: "source/"
                    }
                ]
            }
        }
    });
    grunt.loadNpmTasks("grunt-contrib-copy");
    grunt.registerTask("default", ["copy"]);
};