// if the user's email start with an 'm', they get the 'mrole' otherwise they get 'admin'

module.exports = async function (context, req) {
    const user = req.body || {};
    let roles = ['admin'];
    if (user.userDetails.startsWith('m'))
    {
        roles = ['mrole'];
    }

    context.res.json({
        roles
    });
}
